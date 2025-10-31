using SoftPos.Data.InventoryModel;
using SQLite;

namespace SoftPos.Services
{
    public class ExpenseCategoryService
    {
        private readonly SQLiteAsyncConnection _database;

        public ExpenseCategoryService(SQLiteAsyncConnection database)
        {
            _database = database;
        }

        public async Task<List<ExpenseCategory>> GetAllExpenseCategoriesAsync()
        {
            return await _database.Table<ExpenseCategory>().ToListAsync();
        }

        public async Task<List<ExpenseCategory>> GetActiveExpenseCategoriesAsync()
        {
            return await _database.Table<ExpenseCategory>()
                .Where(ec => ec.IsActive == true)
                .ToListAsync();
        }

        public async Task<List<ExpenseCategory>> GetExpenseCategoriesByTypeAsync(string categoryType)
        {
            return await _database.Table<ExpenseCategory>()
                .Where(ec => ec.CategoryType == categoryType)
                .ToListAsync();
        }

        public async Task<ExpenseCategory> GetExpenseCategoryByIdAsync(int id)
        {
            return await _database.FindAsync<ExpenseCategory>(id);
        }

        public async Task<int> AddExpenseCategoryAsync(ExpenseCategory expenseCategory)
        {
            // Check if category name already exists
            var existingCategory = await _database.Table<ExpenseCategory>()
                .FirstOrDefaultAsync(ec => ec.CategoryName == expenseCategory.CategoryName);

            if (existingCategory != null)
            {
                return 0; // Category already exists
            }

            expenseCategory.AddedDate = DateTime.UtcNow;
            return await _database.InsertAsync(expenseCategory);
        }

        public async Task<bool> UpdateExpenseCategoryAsync(ExpenseCategory expenseCategory)
        {
            // Check if category name already exists for a different ID
            var existingCategory = await _database.Table<ExpenseCategory>()
                .FirstOrDefaultAsync(ec => ec.CategoryName == expenseCategory.CategoryName && 
                                         ec.ExpenseCategoryId != expenseCategory.ExpenseCategoryId);

            if (existingCategory != null)
            {
                return false; // Category name already exists
            }

            expenseCategory.ModifyDate = DateTime.UtcNow;
            await _database.UpdateAsync(expenseCategory);
            return true;
        }

        public async Task<bool> DeleteExpenseCategoryAsync(int id)
        {
            try
            {
                // Check if category is used in any expenses
                var isCategoryInUse = await _database.Table<Expense>()
                    .CountAsync(e => e.ExpenseCategoryId == id) > 0;

                if (isCategoryInUse)
                {
                    return false; // Category is in use, cannot delete
                }

                await _database.DeleteAsync<ExpenseCategory>(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> ToggleExpenseCategoryStatusAsync(int id)
        {
            try
            {
                var category = await _database.FindAsync<ExpenseCategory>(id);
                if (category != null)
                {
                    category.IsActive = !category.IsActive;
                    category.ModifyDate = DateTime.UtcNow;
                    await _database.UpdateAsync(category);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}










