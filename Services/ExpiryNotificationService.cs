using SoftPos.Data;
using SoftPos.Data.Setting;
using SQLite;

namespace SoftPos.Services
{
    /// <summary>
    /// خدمة إشعارات المنتجات المنتهية الصلاحية
    /// </summary>
    public class ExpiryNotificationService
    {
        private readonly SQLiteAsyncConnection _database;

        public ExpiryNotificationService(SQLiteAsyncConnection database)
        {
            _database = database;
        }

        /// <summary>
        /// الحصول على المنتجات المنتهية الصلاحية
        /// </summary>
        public async Task<List<Product>> GetExpiredProductsAsync()
        {
            var today = DateTime.Today;
            var products = await _database.Table<Product>().ToListAsync();
            
            return products
                .Where(p => p.TrackExpiry && 
                           p.ExpiryDate.HasValue && 
                           p.ExpiryDate.Value.Date < today &&
                           p.IsActive)
                .OrderBy(p => p.ExpiryDate)
                .ToList();
        }

        /// <summary>
        /// الحصول على المنتجات القريبة من انتهاء الصلاحية (خلال عدد أيام محدد)
        /// </summary>
        public async Task<List<Product>> GetExpiringProductsAsync(int daysThreshold = 30)
        {
            var today = DateTime.Today;
            var thresholdDate = today.AddDays(daysThreshold);
            var products = await _database.Table<Product>().ToListAsync();
            
            return products
                .Where(p => p.TrackExpiry && 
                           p.ExpiryDate.HasValue && 
                           p.ExpiryDate.Value.Date >= today &&
                           p.ExpiryDate.Value.Date <= thresholdDate &&
                           p.IsActive)
                .OrderBy(p => p.ExpiryDate)
                .ToList();
        }

        /// <summary>
        /// عدد المنتجات المنتهية الصلاحية
        /// </summary>
        public async Task<int> GetExpiredProductsCountAsync()
        {
            var expiredProducts = await GetExpiredProductsAsync();
            return expiredProducts.Count;
        }

        /// <summary>
        /// عدد المنتجات القريبة من انتهاء الصلاحية
        /// </summary>
        public async Task<int> GetExpiringProductsCountAsync(int daysThreshold = 30)
        {
            var expiringProducts = await GetExpiringProductsAsync(daysThreshold);
            return expiringProducts.Count;
        }

        /// <summary>
        /// الحصول على الأيام المتبقية لانتهاء صلاحية المنتج
        /// </summary>
        public int? GetDaysUntilExpiry(Product product)
        {
            if (!product.TrackExpiry || !product.ExpiryDate.HasValue)
                return null;

            var today = DateTime.Today;
            var daysRemaining = (product.ExpiryDate.Value.Date - today).Days;
            return daysRemaining;
        }

        /// <summary>
        /// التحقق من صلاحية المنتج
        /// </summary>
        public ExpiryStatus GetExpiryStatus(Product product)
        {
            if (!product.TrackExpiry || !product.ExpiryDate.HasValue)
                return ExpiryStatus.NoTracking;

            var daysRemaining = GetDaysUntilExpiry(product);
            
            if (!daysRemaining.HasValue)
                return ExpiryStatus.NoTracking;

            if (daysRemaining.Value < 0)
                return ExpiryStatus.Expired;
            
            if (daysRemaining.Value <= 7)
                return ExpiryStatus.CriticalExpiring;
            
            if (daysRemaining.Value <= 30)
                return ExpiryStatus.Expiring;
            
            return ExpiryStatus.Valid;
        }
    }

    /// <summary>
    /// حالة صلاحية المنتج
    /// </summary>
    public enum ExpiryStatus
    {
        NoTracking,      // لا يتم تتبع الصلاحية
        Valid,           // صالح
        Expiring,        // قريب من الانتهاء (30 يوم)
        CriticalExpiring, // قريب جداً من الانتهاء (7 أيام)
        Expired          // منتهي الصلاحية
    }
}
