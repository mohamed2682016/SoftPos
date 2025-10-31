using SoftPos.Data.Setting;
using SoftPos.Data.SettingView;
using SQLite;

namespace SoftPos.Services
{
    public class CompanyService
    {
        private readonly SQLiteAsyncConnection _database;
        public CompanyService(SQLiteAsyncConnection database)
        {
            _database = database;
        }
        public async Task<Company> GetAllCompaniesAsync()
        {
            return await _database.Table<Company>().FirstOrDefaultAsync();
        }

        public async Task<CompanyView> GetCompanyAsync()
        {
            try
            {
                // Fetch data from the tables asynchronously
                var companies = await _database.Table<Company>().ToListAsync();
                var currencies = await _database.Table<Currency>().ToListAsync();

                // Perform the join using LINQ and get the first company
                var query = (from company in companies
                             join currency in currencies
                             on company.CurrencyId equals currency.CurrencyId into currencyGroup
                             from currency in currencyGroup.DefaultIfEmpty()
                             select new CompanyView
                             {
                                 CompanyId = company.CompanyId,
                                 CompanyName = company.CompanyName,
                                 Address = company.Address,
                                 WarehouseId = company.WarehouseId,
                                 MobileNo = company.MobileNo,
                                 Email = company.Email,
                                 FinancialYearId = company.FinancialYearId,
                                 CurrencyId = currency?.CurrencyId ?? 0,
                                 CurrencySymbol = currency?.CurrencySymbol ?? "$",
                                 NoofDecimal = currency?.NoOfDecimalPlaces ?? 2,
                                 LicenseKey = company.LicenseKey,
                                 MachineId = company.MachineId,
                                 Date = company.Date,
                                 ExpiryDate = company.ExpiryDate
                             }).FirstOrDefault();

                return query ?? new CompanyView();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching company data: {ex.Message}");
                return new CompanyView();
            }
        }
        public async Task<Company> GetCompanyByIdAsync(int id)
        {
            return await _database.FindAsync<Company>(id);
        }
        public async Task<CompanyView> GetAllCompaniesByIdAsync(int companyId)
        {
            try
            {
                // Fetch data from the tables asynchronously
                var companies = await _database.Table<Company>().ToListAsync();
                var currencies = await _database.Table<Currency>().ToListAsync();

                // Perform the join and filter using LINQ
                var query = (from company in companies
                             join currency in currencies
                             on company.CurrencyId equals currency.CurrencyId
                             where company.CompanyId == companyId
                             select new CompanyView
                             {
                                 CompanyId = company.CompanyId,
                                 CompanyName = company.CompanyName,
                                 Address = company.Address,
                                 WarehouseId = company.WarehouseId,
                                 MobileNo = company.MobileNo,
                                 Email = company.Email,
                                 FinancialYearId = company.FinancialYearId,
                                 CurrencyId = currency.CurrencyId,
                                 CurrencySymbol = currency.CurrencySymbol,
                                 NoofDecimal = currency.NoOfDecimalPlaces,
                                 LicenseKey = company.LicenseKey,
                                 MachineId = company.MachineId,
                                 Date = company.Date,
                                 ExpiryDate = company.ExpiryDate
                                 
                             }).FirstOrDefault();

                return query;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching company data by ID using LINQ: {ex.Message}");
                throw;
            }
        }


        public async Task<bool> UpdateCompanyAsync(Company Company)
        {
            Company.ModifyDate = DateTime.UtcNow;
            await _database.UpdateAsync(Company);
            return true;
        }
    }
}
