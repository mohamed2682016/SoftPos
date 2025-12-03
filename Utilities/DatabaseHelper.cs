using SoftPos.Data;

namespace SoftPos.Utilities
{
    public static class DatabaseHelper
    {
        /// <summary>
        /// إعادة تعيين قاعدة البيانات بالكامل (حذف وإعادة إنشاء)
        /// </summary>
        public static async Task<bool> ResetDatabaseAsync(DatabaseContext databaseContext)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("Starting complete database reset...");
                
                // Reset the database
                await databaseContext.ResetDatabaseAsync();
                
                // Reinitialize
                await databaseContext.InitializeAsync();
                
                // Seed data
                await SeedAllDataAsync(databaseContext);
                
                // Update settings
                DatabaseSettings.SaveDatabaseVersion(DatabaseSettings.CurrentDatabaseVersion);
                DatabaseSettings.SaveLastResetDate();
                
                System.Diagnostics.Debug.WriteLine("Database reset completed successfully!");
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database reset failed: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// تهيئة البيانات الأساسية
        /// </summary>
        public static async Task SeedAllDataAsync(DatabaseContext databaseContext)
        {
            try
            {
                await databaseContext.SeedCompanyDataAsync();
                await databaseContext.SeedUserDataAsync();
                await databaseContext.SeedAccountgroupDataAsync();
                await databaseContext.SeedAccountledgerDataAsync();
                await databaseContext.SeedTaxDataAsync();
                await databaseContext.SeedUnitDataAsync();
                await databaseContext.SeedPaymentTypeDataAsync();
                await databaseContext.SeedCategoryDataAsync();
                await databaseContext.SeedWarehouseDataAsync();
                await databaseContext.SeedInvoiceSettingDataAsync();
                await databaseContext.SeedCurrencyDataAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error seeding data: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// فحص حالة قاعدة البيانات
        /// </summary>
        public static async Task<bool> CheckDatabaseHealthAsync(DatabaseContext databaseContext)
        {
            try
            {
                // Try to perform a simple query to check if database is working
                var connection = databaseContext.GetConnection();
                var userCount = await connection.Table<SoftPos.Data.User.UserMaster>().CountAsync();
                System.Diagnostics.Debug.WriteLine($"Database health check passed. User count: {userCount}");
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database health check failed: {ex.Message}");
                return false;
            }
        }
    }
}