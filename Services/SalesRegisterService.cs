using Azure;
using Microsoft.Data.SqlClient;
using SoftPos.Data.InventoryModel;
using SoftPos.Data.InventoryModelView;
using SoftPos.Data.Setting;
using SoftPos.Data.User;
using SQLite;
using System.Data;

namespace SoftPos.Services
{
    public class SalesRegisterService
    {
        private readonly SQLiteAsyncConnection _database;
        public SalesRegisterService(SQLiteAsyncConnection database)
        {
            _database = database;
        }
        public async Task<List<SalesRegisterClosingBalanceView>> GetAll(int userId, DateTime fromDate, DateTime toDate)
        {
            try
            {
                // Fetch Users
                var users = await _database.Table<UserMaster>().ToListAsync();

                // Fetch SalesRegisters filtered by date range and user
                var salesRegisters = await _database.Table<SalesRegister>()
                    .Where(sr => sr.OpeningTime >= fromDate && sr.OpeningTime <= toDate)
                    .Where(sr => userId == 0 || sr.UserId == userId)
                    .ToListAsync();

                // Fetch SalesRegisterClosingBalances
                var salesRegisterClosingBalances = await _database.Table<SalesRegisterClosingBalance>().ToListAsync();

                // If we have sales registers but no closing balances, show basic register info
                if (salesRegisters?.Any() == true && salesRegisterClosingBalances?.Count == 0)
                {
                    var basicResult = (from user in users
                                      join sr in salesRegisters on user.UserId equals sr.UserId
                                      select new SalesRegisterClosingBalanceView
                                      {
                                          FullName = user.Username,
                                          OpeningCashAmount = sr.OpeningCashAmount,
                                          Status = sr.Status,
                                          Cash = 0,
                                          Card = 0,
                                          UPI = 0,
                                          TotalSales = 0,
                                          PayLater = 0,
                                          CreditAppliedAmount = 0,
                                          SalesReturnAmount = 0,
                                          ClosingAmount = sr.ClosingCashAmount,
                                          OpeningTime = sr.OpeningTime,
                                          ClosingTime = sr.ClosingTime
                                      }).ToList();
                    
                    return basicResult;
                }

                // Perform the join and grouping operation in memory
                var result = (from user in users
                              join sr in salesRegisters on user.UserId equals sr.UserId
                              join srcb in salesRegisterClosingBalances on sr.SalesRegisterId equals srcb.SalesRegisterId into srcbJoin
                              from srcb in srcbJoin.DefaultIfEmpty()
                              group new { sr, srcb } by new
                              {
                                  user.Username,
                                  sr.SalesRegisterId,
                                  sr.OpeningCashAmount,
                                  sr.Status,
                                  sr.OpeningTime,
                                  sr.ClosingTime
                              } into grouped
                              select new SalesRegisterClosingBalanceView
                              {
                                  FullName = grouped.Key.Username,
                                  OpeningCashAmount = grouped.Key.OpeningCashAmount,
                                  Status = grouped.Key.Status,
                                  Cash = grouped.Sum(x => x.srcb?.PaymentMethodId == 1 ? x.srcb.Amount : 0),
                                  Card = grouped.Sum(x => x.srcb?.PaymentMethodId == 2 ? x.srcb.Amount : 0),
                                  UPI = grouped.Sum(x => x.srcb?.PaymentMethodId == 3 ? x.srcb.Amount : 0),
                                  TotalSales = grouped.Sum(x =>
                                      (x.srcb?.PaymentMethodId == 1 ? x.srcb.Amount : 0) +
                                      (x.srcb?.PaymentMethodId == 2 ? x.srcb.Amount : 0) +
                                      (x.srcb?.PaymentMethodId == 3 ? x.srcb.Amount : 0)),
                                  PayLater = grouped.Sum(x => x.srcb?.PayLater ?? 0),
                                  CreditAppliedAmount = grouped.Sum(x => x.srcb?.CreditAppliedAmount ?? 0),
                                  SalesReturnAmount = grouped.Sum(x => x.srcb?.SalesReturnAmount ?? 0),
                                  ClosingAmount = grouped.Key.OpeningCashAmount + grouped.Sum(x =>
                                      (x.srcb?.PaymentMethodId == 1 ? x.srcb.Amount : 0) +
                                      (x.srcb?.PaymentMethodId == 2 ? x.srcb.Amount : 0) +
                                      (x.srcb?.PaymentMethodId == 3 ? x.srcb.Amount : 0)),
                                  OpeningTime = grouped.Key.OpeningTime,
                                  ClosingTime = grouped.Key.ClosingTime
                              }).ToList();

                return result;
            }
            catch (Exception ex)
            {
                return new List<SalesRegisterClosingBalanceView>();
            }
        }

        public async Task<List<SalesRegisterClosingBalanceView>> CashRegisterAsync(int userId)
        {
            try
            {
                // Fetch PaymentTypes
                var paymentTypes = await _database.Table<PaymentType>().ToListAsync();

                // Fetch SalesRegisters with the required filter
                var salesRegisters = await _database.Table<SalesRegister>()
                    .Where(sr => sr.Status == "Open" && sr.UserId == userId)
                    .ToListAsync();

                // Fetch SalesRegisterClosingBalances for open registers only
                var salesRegisterClosingBalances = await _database.Table<SalesRegisterClosingBalance>().ToListAsync();

                // Filter closing balances to only include those from open registers
                var validClosingBalances = salesRegisterClosingBalances
                    .Where(srcb => salesRegisters.Any(sr => sr.SalesRegisterId == srcb.SalesRegisterId))
                    .ToList();

                // Perform the join and group operation in memory
                var result = (from pt in paymentTypes
                              join srcb in validClosingBalances
                              on pt.PaymentTypeId equals srcb.PaymentMethodId into srcbJoin
                              from srcb in srcbJoin.DefaultIfEmpty()
                              where srcb != null // Only include payment types that have transactions
                              group srcb by new { pt.PaymentTypeId, pt.Name } into grouped
                              orderby grouped.Key.PaymentTypeId
                              select new SalesRegisterClosingBalanceView
                              {
                                  PaymentId = grouped.Key.PaymentTypeId,
                                  Name = grouped.Key.Name,
                                  Amount = grouped.Sum(x => x.Amount)
                              }).ToList();

                // Add payment types with zero amounts if they don't have transactions
                var existingPaymentIds = result.Select(r => r.PaymentId).ToList();
                var missingPaymentTypes = paymentTypes
                    .Where(pt => !existingPaymentIds.Contains(pt.PaymentTypeId))
                    .Select(pt => new SalesRegisterClosingBalanceView
                    {
                        PaymentId = pt.PaymentTypeId,
                        Name = pt.Name,
                        Amount = 0
                    }).ToList();

                result.AddRange(missingPaymentTypes);
                result = result.OrderBy(r => r.PaymentId).ToList();

                return result;
            }
            catch (Exception ex)
            {
                return new List<SalesRegisterClosingBalanceView>();
            }
        }
        public async Task<List<SalesRegisterClosingBalanceView>> CloseReturnAsync(int userId)
        {
            // SQL query for SQLite
            string query = @"
SELECT 
    IFNULL(SUM(srcb.PayLater), 0) AS PayLater,
    IFNULL(SUM(srcb.CreditAppliedAmount), 0) AS CreditAppliedAmount,
    IFNULL(SUM(srcb.SalesReturnAmount), 0) AS SalesReturnAmount,
    IFNULL(SUM(srcb.ClosingAmount), 0) AS ClosingAmount,
    IFNULL(SUM(srcb.CashReturnAmount), 0) AS CashReturnAmount,
    IFNULL(SUM(srcb.ExpenseAmount), 0) AS ExpenseAmount,
    IFNULL(SUM(srcb.PurchasePayment), 0) AS PurchasePayment
FROM SalesRegisterClosingBalance srcb
INNER JOIN SalesRegister sr 
    ON srcb.SalesRegisterId = sr.SalesRegisterId
WHERE sr.UserId = ? AND sr.Status = 'Open'";

            try
            {
                // Execute the query and map results
                var result = await _database.QueryAsync<SalesRegisterClosingBalanceView>(query, userId);

                // If no result is returned, initialize with default values
                return result;
            }
            catch (Exception ex)
            {
                return new List<SalesRegisterClosingBalanceView>();
            }
        }


        public async Task<SalesRegister> OpeningCashAsync(int userId)
        {
            var query = await _database.Table<SalesRegister>()
                                        .Where(progm => progm.UserId == userId && progm.Status == "Open")
                                        .FirstOrDefaultAsync();
            return query;
        }
        public async Task<bool> CheckNameId(SalesRegister model)
        {
            var query = await _database.Table<SalesRegister>()
                                        .Where(progm => progm.UserId == model.UserId && progm.Status == "Open")
                                        .CountAsync();
            if (query > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> CloseBalanceAsync(SalesRegister model)
        {
            try
            {
                // Check if there are any open sales registers for the user
                var openSalesRegister = await _database.Table<SalesRegister>()
                                                        .Where(sr => sr.UserId == model.UserId && sr.Status == "Open")
                                                        .FirstOrDefaultAsync();

                if (openSalesRegister == null)
                {
                    // Try to create a new register first
                    var newRegister = new SalesRegister
                    {
                        UserId = model.UserId,
                        OpeningTime = DateTime.UtcNow.AddHours(-1),
                        OpeningCashAmount = 0,
                        Status = "Open",
                        Notes = "تم إنشاؤه تلقائياً",
                        AddedDate = DateTime.UtcNow
                    };
                    
                    var insertResult = await _database.InsertAsync(newRegister);
                    if (insertResult > 0)
                    {
                        openSalesRegister = newRegister;
                    }
                    else
                    {
                        return false;
                    }
                }

                // Update the existing sales register record with closing details
                openSalesRegister.ClosingTime = DateTime.UtcNow;
                openSalesRegister.ClosingCashAmount = model.ClosingCashAmount;
                openSalesRegister.Status = "Close";
                openSalesRegister.Notes = model.Notes ?? openSalesRegister.Notes;
                openSalesRegister.CashLeftinDrawer = model.CashLeftinDrawer;
                openSalesRegister.PhysicalDrawer = model.PhysicalDrawer;
                openSalesRegister.ModifyDate = DateTime.UtcNow;

                // Update the existing record instead of creating a new one
                var updateResult = await _database.UpdateAsync(openSalesRegister);
                
                if (updateResult == 0)
                {
                    return false;
                }
                
                // Get total sales from existing closing balance records for this register
                var existingSales = await _database.Table<SalesRegisterClosingBalance>()
                    .Where(cb => cb.SalesRegisterId == openSalesRegister.SalesRegisterId)
                    .ToListAsync();
                
                decimal totalSalesAmount = existingSales.Sum(x => x.Amount);
                decimal expectedClosingAmount = openSalesRegister.OpeningCashAmount + totalSalesAmount;
                
                // Update the register with actual closing amounts
                openSalesRegister.ClosingCashAmount = model.ClosingCashAmount;
                
                // Don't create a new closing balance record here - it's already created when sales are made
                // Just update the register status and amounts

                // No need to insert a new closing balance record
                // The sales transactions are already recorded in SalesRegisterClosingBalance

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<int> SaveAsync(SalesRegister model)
        {
            try
            {
                var existingCount = await _database.Table<SalesRegister>()
                                            .Where(progm => progm.UserId == model.UserId && progm.Status == "Open")
                                            .CountAsync();
                
                if (existingCount > 0)
                {
                    return 0;
                }
                else
                {
                    var result = await _database.InsertAsync(model);
                    return result;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }



        public async Task<int> AddSaleToRegister(SalesRegisterClosingBalance closingBalance)
        {
            try
            {
                var result = await _database.InsertAsync(closingBalance);
                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
