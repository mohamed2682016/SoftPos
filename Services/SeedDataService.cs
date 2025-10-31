using SoftPos.Data.InventoryModel;
using SQLite;

namespace SoftPos.Services
{
    public class SeedDataService
    {
        private readonly SQLiteAsyncConnection _database;

        public SeedDataService(SQLiteAsyncConnection database)
        {
            _database = database;
        }

        public async Task SeedExpenseCategoriesAsync()
        {
            try
            {
                // Check if categories already exist
                var existingCategories = await _database.Table<ExpenseCategory>().CountAsync();
                if (existingCategories > 0)
                {
                    return; // Categories already exist
                }

                var defaultCategories = new List<ExpenseCategory>
                {
                    // Employee Expenses
                    new ExpenseCategory { CategoryName = "راتب العمال", CategoryType = "Employee", Description = "رواتب العمال الشهرية", IsActive = true },
                    new ExpenseCategory { CategoryName = "مكافآت العمال", CategoryType = "Employee", Description = "مكافآت وحوافز العمال", IsActive = true },
                    new ExpenseCategory { CategoryName = "تأمين العمال", CategoryType = "Employee", Description = "تأمين صحي واجتماعي للعمال", IsActive = true },
                    new ExpenseCategory { CategoryName = "تدريب العمال", CategoryType = "Employee", Description = "دورات تدريبية للعمال", IsActive = true },

                    // Owner Expenses
                    new ExpenseCategory { CategoryName = "إيجار المحل", CategoryType = "Owner", Description = "إيجار المحل الشهري", IsActive = true },
                    new ExpenseCategory { CategoryName = "فاتورة الكهرباء", CategoryType = "Owner", Description = "فاتورة الكهرباء", IsActive = true },
                    new ExpenseCategory { CategoryName = "فاتورة المياه", CategoryType = "Owner", Description = "فاتورة المياه", IsActive = true },
                    new ExpenseCategory { CategoryName = "فاتورة الهاتف", CategoryType = "Owner", Description = "فاتورة الهاتف والإنترنت", IsActive = true },
                    new ExpenseCategory { CategoryName = "صيانة المحل", CategoryType = "Owner", Description = "صيانة وتجديد المحل", IsActive = true },
                    new ExpenseCategory { CategoryName = "ترخيص المحل", CategoryType = "Owner", Description = "رسوم الترخيص والضرائب", IsActive = true },

                    // Waste Categories
                    new ExpenseCategory { CategoryName = "منتجات منتهية الصلاحية", CategoryType = "Waste", Description = "منتجات انتهت صلاحيتها", IsActive = true },
                    new ExpenseCategory { CategoryName = "منتجات تالفة", CategoryType = "Waste", Description = "منتجات تالفة أو مكسورة", IsActive = true },
                    new ExpenseCategory { CategoryName = "منتجات مسروقة", CategoryType = "Waste", Description = "منتجات مفقودة أو مسروقة", IsActive = true },

                    // Other Expenses
                    new ExpenseCategory { CategoryName = "نقل وتوصيل", CategoryType = "Other", Description = "مصاريف النقل والتوصيل", IsActive = true },
                    new ExpenseCategory { CategoryName = "تسويق وإعلان", CategoryType = "Other", Description = "مصاريف التسويق والإعلان", IsActive = true },
                    new ExpenseCategory { CategoryName = "مصاريف إدارية", CategoryType = "Other", Description = "مصاريف إدارية متنوعة", IsActive = true },
                    new ExpenseCategory { CategoryName = "مصاريف طوارئ", CategoryType = "Other", Description = "مصاريف طوارئ غير متوقعة", IsActive = true }
                };

                await _database.InsertAllAsync(defaultCategories);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error seeding expense categories: {ex.Message}");
            }
        }

        public async Task SeedAllDataAsync()
        {
            await SeedExpenseCategoriesAsync();
        }
    }
}