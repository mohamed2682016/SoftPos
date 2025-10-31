using SoftPos.Data.InventoryModel;
using SQLite;

namespace SoftPos.Services
{
    public class WasteService
    {
        private readonly SQLiteAsyncConnection _database;

        public WasteService(SQLiteAsyncConnection database)
        {
            _database = database;
        }

        public async Task<List<Waste>> GetAllWasteAsync()
        {
            return await _database.Table<Waste>().ToListAsync();
        }

        public async Task<List<Waste>> GetWasteByDateRangeAsync(DateTime fromDate, DateTime toDate)
        {
            return await _database.Table<Waste>()
                .Where(w => w.WasteDate >= fromDate && w.WasteDate <= toDate)
                .ToListAsync();
        }

        public async Task<List<Waste>> GetWasteByTypeAsync(string wasteType)
        {
            return await _database.Table<Waste>()
                .Where(w => w.WasteType == wasteType)
                .ToListAsync();
        }

        public async Task<List<Waste>> GetWasteByProductAsync(int productId)
        {
            return await _database.Table<Waste>()
                .Where(w => w.ProductId == productId)
                .ToListAsync();
        }

        public async Task<List<Waste>> GetWasteByWarehouseAsync(int warehouseId)
        {
            return await _database.Table<Waste>()
                .Where(w => w.WarehouseId == warehouseId)
                .ToListAsync();
        }

        public async Task<Waste> GetWasteByIdAsync(int id)
        {
            return await _database.FindAsync<Waste>(id);
        }

        public async Task<int> AddWasteAsync(Waste waste)
        {
            waste.AddedDate = DateTime.UtcNow;
            return await _database.InsertAsync(waste);
        }

        public async Task<bool> UpdateWasteAsync(Waste waste)
        {
            waste.ModifyDate = DateTime.UtcNow;
            await _database.UpdateAsync(waste);
            return true;
        }

        public async Task<bool> DeleteWasteAsync(int id)
        {
            try
            {
                await _database.DeleteAsync<Waste>(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> ApproveWasteAsync(int wasteId, int approvedBy)
        {
            try
            {
                var waste = await _database.FindAsync<Waste>(wasteId);
                if (waste != null)
                {
                    waste.IsApproved = true;
                    waste.ApprovedBy = approvedBy;
                    waste.ApprovedDate = DateTime.UtcNow;
                    waste.ModifyDate = DateTime.UtcNow;
                    await _database.UpdateAsync(waste);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<decimal> GetTotalWasteByTypeAsync(string wasteType, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var query = _database.Table<Waste>().Where(w => w.WasteType == wasteType);
            
            if (fromDate.HasValue)
                query = query.Where(w => w.WasteDate >= fromDate.Value);
            
            if (toDate.HasValue)
                query = query.Where(w => w.WasteDate <= toDate.Value);

            var wasteItems = await query.ToListAsync();
            return wasteItems.Sum(w => w.TotalAmount);
        }

        public async Task<decimal> GetTotalWasteByProductAsync(int productId, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var query = _database.Table<Waste>().Where(w => w.ProductId == productId);
            
            if (fromDate.HasValue)
                query = query.Where(w => w.WasteDate >= fromDate.Value);
            
            if (toDate.HasValue)
                query = query.Where(w => w.WasteDate <= toDate.Value);

            var wasteItems = await query.ToListAsync();
            return wasteItems.Sum(w => w.TotalAmount);
        }

        public async Task<decimal> GetTotalWasteByWarehouseAsync(int warehouseId, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var query = _database.Table<Waste>().Where(w => w.WarehouseId == warehouseId);
            
            if (fromDate.HasValue)
                query = query.Where(w => w.WasteDate >= fromDate.Value);
            
            if (toDate.HasValue)
                query = query.Where(w => w.WasteDate <= toDate.Value);

            var wasteItems = await query.ToListAsync();
            return wasteItems.Sum(w => w.TotalAmount);
        }

        public async Task<List<Waste>> GetWasteSummaryAsync(DateTime fromDate, DateTime toDate)
        {
            return await _database.Table<Waste>()
                .Where(w => w.WasteDate >= fromDate && w.WasteDate <= toDate)
                .OrderByDescending(w => w.WasteDate)
                .ToListAsync();
        }
    }
}










