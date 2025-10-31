using SoftPos.Data.InventoryModel;
using SQLite;

namespace SoftPos.Services
{
    public class ExpenseService
    {
        private readonly SQLiteAsyncConnection _database;

        public ExpenseService(SQLiteAsyncConnection database)
        {
            _database = database;
        }

        public async Task<List<Expense>> GetAllExpensesAsync()
        {
            return await _database.Table<Expense>().ToListAsync();
        }

        public async Task<List<Expense>> GetExpensesByDateRangeAsync(DateTime fromDate, DateTime toDate)
        {
            return await _database.Table<Expense>()
                .Where(e => e.ExpenseDate >= fromDate && e.ExpenseDate <= toDate)
                .ToListAsync();
        }

        public async Task<List<Expense>> GetExpensesByTypeAsync(string expenseType)
        {
            return await _database.Table<Expense>()
                .Where(e => e.ExpenseType == expenseType)
                .ToListAsync();
        }

        public async Task<List<Expense>> GetExpensesByCategoryAsync(int categoryId)
        {
            return await _database.Table<Expense>()
                .Where(e => e.ExpenseCategoryId == categoryId)
                .ToListAsync();
        }

        public async Task<Expense> GetExpenseByIdAsync(int id)
        {
            return await _database.FindAsync<Expense>(id);
        }

        public async Task<int> AddExpenseAsync(Expense expense)
        {
            expense.AddedDate = DateTime.UtcNow;
            return await _database.InsertAsync(expense);
        }

        public async Task<bool> UpdateExpenseAsync(Expense expense)
        {
            expense.ModifyDate = DateTime.UtcNow;
            await _database.UpdateAsync(expense);
            return true;
        }

        public async Task<bool> DeleteExpenseAsync(int id)
        {
            try
            {
                await _database.DeleteAsync<Expense>(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> ApproveExpenseAsync(int expenseId, int approvedBy)
        {
            try
            {
                var expense = await _database.FindAsync<Expense>(expenseId);
                if (expense != null)
                {
                    expense.IsApproved = true;
                    expense.ApprovedBy = approvedBy;
                    expense.ApprovedDate = DateTime.UtcNow;
                    expense.ModifyDate = DateTime.UtcNow;
                    await _database.UpdateAsync(expense);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<decimal> GetTotalExpensesByTypeAsync(string expenseType, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var query = _database.Table<Expense>().Where(e => e.ExpenseType == expenseType);
            
            if (fromDate.HasValue)
                query = query.Where(e => e.ExpenseDate >= fromDate.Value);
            
            if (toDate.HasValue)
                query = query.Where(e => e.ExpenseDate <= toDate.Value);

            var expenses = await query.ToListAsync();
            return expenses.Sum(e => e.Amount);
        }

        public async Task<decimal> GetTotalExpensesByCategoryAsync(int categoryId, DateTime? fromDate = null, DateTime? toDate = null)
        {
            var query = _database.Table<Expense>().Where(e => e.ExpenseCategoryId == categoryId);
            
            if (fromDate.HasValue)
                query = query.Where(e => e.ExpenseDate >= fromDate.Value);
            
            if (toDate.HasValue)
                query = query.Where(e => e.ExpenseDate <= toDate.Value);

            var expenses = await query.ToListAsync();
            return expenses.Sum(e => e.Amount);
        }
    }
}
