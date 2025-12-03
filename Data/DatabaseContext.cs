using SoftPos.Data.Account;
using SoftPos.Data.InventoryModel;
using SoftPos.Data.Setting;
using SoftPos.Data.User;
using SoftPos.Data.UserView;
using SoftPos.Services;
using SQLite;

using SoftPos.Utilities;
namespace SoftPos.Data
{
    public class DatabaseContext : IAsyncDisposable
    {
        private const string DbName = "SoftPos.db3";
        private static string DbPath
        {
            get
            {
                try
                {
                    var path = Path.Combine(FileSystem.AppDataDirectory, DbName);
                    System.Diagnostics.Debug.WriteLine($"Database path: {path}");
                    
                    // Ensure directory exists
                    var directory = Path.GetDirectoryName(path);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                        System.Diagnostics.Debug.WriteLine($"Created directory: {directory}");
                    }
                    
                    return path;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error getting database path: {ex.Message}");
                    throw;
                }
            }
        }

        private SQLiteAsyncConnection _connection;
        private SQLiteAsyncConnection Database
        {
            get
            {
                if (_connection == null)
                {
                    try
                    {
                        _connection = new SQLiteAsyncConnection(DbPath,
                            SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.SharedCache);
                        System.Diagnostics.Debug.WriteLine("Database connection created successfully");
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error creating database connection: {ex.Message}");
                        throw;
                    }
                }
                return _connection;
            }
        }

        public async Task InitializeAsync()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Starting database table creation...");
                
                // Create tables with CreateTableIfNotExists to avoid conflicts
                var createTableOptions = CreateFlags.None;
                
                await Database.CreateTableAsync<UserMaster>(createTableOptions);
                await Database.CreateTableAsync<AccountGroup>(createTableOptions);
                await Database.CreateTableAsync<AccountLedger>(createTableOptions);
                await Database.CreateTableAsync<StockPosting>(createTableOptions);
                await Database.CreateTableAsync<LedgerPosting>(createTableOptions);
                await Database.CreateTableAsync<PurchaseMaster>(createTableOptions);
                await Database.CreateTableAsync<PurchaseDetails>(createTableOptions);
                await Database.CreateTableAsync<PurchaseReturnMaster>(createTableOptions);
                await Database.CreateTableAsync<PurchaseReturnDetails>(createTableOptions);
                await Database.CreateTableAsync<SalesMaster>(createTableOptions);
                await Database.CreateTableAsync<SalesDetails>(createTableOptions);
                await Database.CreateTableAsync<SalesRegister>(createTableOptions);
                await Database.CreateTableAsync<PosCreditNoteMaster>(createTableOptions);
                await Database.CreateTableAsync<PosCreditNoteDetails>(createTableOptions);
                await Database.CreateTableAsync<SalesRegisterClosingBalance>(createTableOptions);
                await Database.CreateTableAsync<SalesReturnMaster>(createTableOptions);
                await Database.CreateTableAsync<SalesReturnDetails>(createTableOptions);
                await Database.CreateTableAsync<PaymentMaster>(createTableOptions);
                await Database.CreateTableAsync<PaymentDetails>(createTableOptions);
                await Database.CreateTableAsync<ReceiptMaster>(createTableOptions);
                await Database.CreateTableAsync<ReceiptDetails>(createTableOptions);
                await Database.CreateTableAsync<TilesQuotationMaster>(createTableOptions);
                await Database.CreateTableAsync<TilesQuotationDetails>(createTableOptions);
                await Database.CreateTableAsync<GreniteQuotation>(createTableOptions);
                await Database.CreateTableAsync<GreniteQuotationDetails>(createTableOptions);
                await Database.CreateTableAsync<Unit>(createTableOptions);
                await Database.CreateTableAsync<Tax>(createTableOptions);
                await Database.CreateTableAsync<ProductGroup>(createTableOptions);
                await Database.CreateTableAsync<Brand>(createTableOptions);
                await Database.CreateTableAsync<Batch>(createTableOptions);
                await Database.CreateTableAsync<Company>(createTableOptions);
                await Database.CreateTableAsync<Coupon>(createTableOptions);
                await Database.CreateTableAsync<EmailSetting>(createTableOptions);
                await Database.CreateTableAsync<FinancialYear>(createTableOptions);
                await Database.CreateTableAsync<GeneralSetting>(createTableOptions);
                await Database.CreateTableAsync<InvoiceSetting>(createTableOptions);
                await Database.CreateTableAsync<PaymentType>(createTableOptions);
                await Database.CreateTableAsync<Currency>(createTableOptions);
                await Database.CreateTableAsync<Privilege>(createTableOptions);
                await Database.CreateTableAsync<Warehouse>(createTableOptions);
                await Database.CreateTableAsync<Product>(createTableOptions);
                await Database.CreateTableAsync<Expense>(createTableOptions);
                await Database.CreateTableAsync<ExpenseCategory>(createTableOptions);
                await Database.CreateTableAsync<Waste>(createTableOptions);
                
                System.Diagnostics.Debug.WriteLine("Database table creation completed successfully!");
                
                // Seed initial data
                await SeedInitialDataAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error creating database tables: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                
                // Try to handle specific SQLite errors
                if (ex.Message.Contains("PRIMARY KEY") || ex.Message.Contains("already exists") || 
                    ex.Message.Contains("table") || ex.Message.Contains("column"))
                {
                    System.Diagnostics.Debug.WriteLine("Database schema conflict detected, attempting recovery...");
                    
                    try
                    {
                        // Try to reset the database if there are schema conflicts
                        await ResetDatabaseAsync();
                        System.Diagnostics.Debug.WriteLine("Database reset completed, retrying table creation...");
                        
                        // Retry table creation after reset
                        await CreateTablesAsync();
                        System.Diagnostics.Debug.WriteLine("Database tables created successfully after reset!");
                        return;
                    }
                    catch (Exception resetEx)
                    {
                        System.Diagnostics.Debug.WriteLine($"Database reset failed: {resetEx.Message}");
                        // Continue without throwing to allow app to start
                        return;
                    }
                }
                
                // For other errors, just log and continue
                System.Diagnostics.Debug.WriteLine("Non-critical database error, continuing...");
            }
        }

        private async Task CreateTablesAsync()
        {
            var createTableOptions = CreateFlags.None;
            
            await Database.CreateTableAsync<UserMaster>(createTableOptions);
            await Database.CreateTableAsync<AccountGroup>(createTableOptions);
            await Database.CreateTableAsync<AccountLedger>(createTableOptions);
            await Database.CreateTableAsync<StockPosting>(createTableOptions);
            await Database.CreateTableAsync<LedgerPosting>(createTableOptions);
            await Database.CreateTableAsync<PurchaseMaster>(createTableOptions);
            await Database.CreateTableAsync<PurchaseDetails>(createTableOptions);
            await Database.CreateTableAsync<PurchaseReturnMaster>(createTableOptions);
            await Database.CreateTableAsync<PurchaseReturnDetails>(createTableOptions);
            await Database.CreateTableAsync<SalesMaster>(createTableOptions);
            await Database.CreateTableAsync<SalesDetails>(createTableOptions);
            await Database.CreateTableAsync<SalesRegister>(createTableOptions);
            await Database.CreateTableAsync<PosCreditNoteMaster>(createTableOptions);
            await Database.CreateTableAsync<PosCreditNoteDetails>(createTableOptions);
            await Database.CreateTableAsync<SalesRegisterClosingBalance>(createTableOptions);
            await Database.CreateTableAsync<SalesReturnMaster>(createTableOptions);
            await Database.CreateTableAsync<SalesReturnDetails>(createTableOptions);
            await Database.CreateTableAsync<PaymentMaster>(createTableOptions);
            await Database.CreateTableAsync<PaymentDetails>(createTableOptions);
            await Database.CreateTableAsync<ReceiptMaster>(createTableOptions);
            await Database.CreateTableAsync<ReceiptDetails>(createTableOptions);
            await Database.CreateTableAsync<TilesQuotationMaster>(createTableOptions);
            await Database.CreateTableAsync<TilesQuotationDetails>(createTableOptions);
            await Database.CreateTableAsync<GreniteQuotation>(createTableOptions);
            await Database.CreateTableAsync<GreniteQuotationDetails>(createTableOptions);
            await Database.CreateTableAsync<Unit>(createTableOptions);
            await Database.CreateTableAsync<Tax>(createTableOptions);
            await Database.CreateTableAsync<ProductGroup>(createTableOptions);
            await Database.CreateTableAsync<Brand>(createTableOptions);
            await Database.CreateTableAsync<Batch>(createTableOptions);
            await Database.CreateTableAsync<Company>(createTableOptions);
            await Database.CreateTableAsync<Coupon>(createTableOptions);
            await Database.CreateTableAsync<EmailSetting>(createTableOptions);
            await Database.CreateTableAsync<FinancialYear>(createTableOptions);
            await Database.CreateTableAsync<GeneralSetting>(createTableOptions);
            await Database.CreateTableAsync<InvoiceSetting>(createTableOptions);
            await Database.CreateTableAsync<PaymentType>(createTableOptions);
            await Database.CreateTableAsync<Currency>(createTableOptions);
            await Database.CreateTableAsync<Privilege>(createTableOptions);
            await Database.CreateTableAsync<Warehouse>(createTableOptions);
            await Database.CreateTableAsync<Product>(createTableOptions);
            await Database.CreateTableAsync<Expense>(createTableOptions);
            await Database.CreateTableAsync<ExpenseCategory>(createTableOptions);
            await Database.CreateTableAsync<Waste>(createTableOptions);
        }

        private async Task SeedInitialDataAsync()
        {
            try
            {
                var seedDataService = new SeedDataService(Database);
                await seedDataService.SeedAllDataAsync();
                System.Diagnostics.Debug.WriteLine("Initial data seeded successfully!");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error seeding initial data: {ex.Message}");
            }
        }

        public async Task ResetDatabaseAsync()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Resetting database...");
                
                // Close current connection
                if (_connection != null)
                {
                    await _connection.CloseAsync();
                    _connection = null;
                }
                
                // Delete database file if it exists
                if (File.Exists(DbPath))
                {
                    File.Delete(DbPath);
                    System.Diagnostics.Debug.WriteLine("Database file deleted");
                }
                
                // Wait a moment for file system
                await Task.Delay(100);
                
                System.Diagnostics.Debug.WriteLine("Database reset completed");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error resetting database: {ex.Message}");
                throw;
            }
        }

        public SQLiteAsyncConnection GetConnection() => Database;
        
        public async ValueTask DisposeAsync()
        {
            if (_connection != null)
            {
                await _connection.CloseAsync();
                _connection = null;
            }
        }
        //SeedData for the account group table
        public async Task SeedAccountgroupDataAsync()
        {
            var accountgroup = await Database.Table<AccountGroup>().FirstOrDefaultAsync();
            if (accountgroup == null)
            {
                AccountGroupInfo info = new AccountGroupInfo();
                List<AccountGroup> listGroup = new List<AccountGroup>();
                listGroup = info.GetAccountGroupInfo();
                // Insert default account group data if the table is empty
                foreach (var item in listGroup)
                {
                    await Database.InsertAsync(item);
                }
            }
        }
        //SeedData for the account ledger table
        public async Task SeedAccountledgerDataAsync()
        {
            var accountledger = await Database.Table<AccountLedger>().FirstOrDefaultAsync();
            if (accountledger == null)
            {
                AccountLedgerInfo info = new AccountLedgerInfo();
                List<AccountLedger> listLedger = new List<AccountLedger>();
                listLedger = info.GetAccountLedgerInfo();
                // Insert default account group data if the table is empty
                foreach (var item in listLedger)
                {
                    await Database.InsertAsync(item);
                }
            }
        }
        public async Task SeedTaxDataAsync()
        {
            var tax = await Database.Table<Tax>().FirstOrDefaultAsync();
            if (tax == null)
            {
                // Insert default Tax data if the table is empty
                var defaultTax = new Tax
                {
                    TaxName = "NA",
                    Rate = 0,
                    IsActive = true,
                    AddedDate = DateTimeHelper.Now
                };
                await Database.InsertAsync(defaultTax);
            }
        }
        //SeedData for the unit table
        public async Task SeedUnitDataAsync()
        {
            var unit = await Database.Table<Unit>().FirstOrDefaultAsync();
            if (unit == null)
            {
                UnitInfo info = new UnitInfo();
                List<Unit> listUnit = new List<Unit>();
                listUnit = info.GetUnitInfo();
                // Insert default unit data if the table is empty
                foreach (var item in listUnit)
                {
                    await Database.InsertAsync(item);
                }
            }
        }

        //SeedData for the PaymentType table
        public async Task SeedPaymentTypeDataAsync()
        {
            var paymentType = await Database.Table<PaymentType>().FirstOrDefaultAsync();
            if (paymentType == null)
            {
                PaymentTypeInfo info = new PaymentTypeInfo();
                List<PaymentType> listPaymentType = new List<PaymentType>();
                listPaymentType = info.GetPaymentTypeInfo();
                // Insert default listPaymentType data if the table is empty
                foreach (var item in listPaymentType)
                {
                    await Database.InsertAsync(item);
                }
            }
        }
        // Seed data for the user table
        public async Task SeedUserDataAsync()
        {
            var user = await Database.Table<UserMaster>().FirstOrDefaultAsync();
            if (user == null)
            {
                // Insert default user data if the table is empty
                var defaultuser = new UserMaster
                {
                    Username = "Admin",
                    Email = "admin@gmail.com",
                    Password = "admin123",
                    IsEmailVerified = true,
                    IsActive = true,
                    Role = UserRole.Admin.ToString(),
                    Image = string.Empty,
                    AddedDate = DateTimeHelper.Now
                };
                await Database.InsertAsync(defaultuser);
            }
        }
        // Seed data for the Company table
        public async Task SeedCompanyDataAsync()
        {
            var company = await Database.Table<Company>().FirstOrDefaultAsync();
            if (company == null)
            {
                // Insert default company data if the table is empty
                var defaultCompany = new Company
                {
                    CompanyName = "Soft Solutions",
                    Address = "مصر ",
                    MobileNo = "+1234567890",
                    Email = "info@softsolutins.com",
                    CurrencyId = 1, // Assuming the first currency exists
                    FinancialYearId = 1, // Assuming a financial year exists
                    NoofDecimal = 2,
                    Website = "https://softsolutins.com",
                    WarehouseId = 1, // Assuming a warehouse exists
                    LedgerId = 1, // Assuming a ledger exists
                    GST = "GST123456789",
                    Pan = "PAN123456789",
                    Lut = "LUT123456789",
                    Iec = "IEC123456789",
                    Logo = "https://softsolutins.com/logo.png",
                    LicenseKey = string.Empty,
                    MachineId = string.Empty,
                    Date = DateTimeHelper.Now,
                    ExpiryDate = DateTimeHelper.Now.AddDays(7),
                    IsDefault = true,
                    StartDate = DateTimeHelper.Now,
                    ValidDate = DateTimeHelper.Now.AddYears(1),
                    AddedDate = DateTimeHelper.Now,
                    ModifyDate = DateTimeHelper.Now
                };
                await Database.InsertAsync(defaultCompany);
            }
        }

        // Seed data for the InvoiceSetting table
        public async Task SeedInvoiceSettingDataAsync()
        {
            var invoiceSetting = await Database.Table<InvoiceSetting>().FirstOrDefaultAsync();
            if (invoiceSetting == null)
            {
                InvoiceSettingInfo infoInvoice = new InvoiceSettingInfo();
                List<InvoiceSetting> listInvoice = new List<InvoiceSetting>();
                listInvoice = infoInvoice.GetInvoiceSettingInfo();
                // Insert default invoice setting data if the table is empty
                foreach (var item in listInvoice)
                {
                    await Database.InsertAsync(item);
                }
            }
        }
        public async Task SeedCategoryDataAsync()
        {
            var category = await Database.Table<ProductGroup>().FirstOrDefaultAsync();
            if (category == null)
            {
                // Insert default category data if the table is empty
                var defaultcategory = new ProductGroup
                {
                    GroupName = "GENERAL",
                    GroupUnder = 0,
                    Image = string.Empty,
                    Narration = string.Empty,
                    AddedDate = DateTimeHelper.Now
                };
                await Database.InsertAsync(defaultcategory);
            }
        }

        public async Task SeedWarehouseDataAsync()
        {
            var warehouse = await Database.Table<Warehouse>().FirstOrDefaultAsync();
            if (warehouse == null)
            {
                // Insert default warehouse data if the table is empty
                var defaultwarehouse = new Warehouse
                {
                    Name = "Main Warehouse",
                    Email = string.Empty,
                    Country = string.Empty,
                    City = string.Empty,
                    Mobile = string.Empty,
                    AddedDate = DateTimeHelper.Now
                };
                await Database.InsertAsync(defaultwarehouse);
            }
        }
        public async Task SeedCurrencyDataAsync()
        {
            var currency = await Database.Table<Currency>().FirstOrDefaultAsync();
            if (currency == null)
            {
                // Insert default currency data if the table is empty
                var defaultCurrency = new Currency
                {
                    CurrencyName = "USD",
                    CurrencySymbol = "$",
                    NoOfDecimalPlaces = 2,
                    IsDefault = true,
                    AddedDate = DateTimeHelper.Now
                };
                await Database.InsertAsync(defaultCurrency);
            }
        }
    }
}
