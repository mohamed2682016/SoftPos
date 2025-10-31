using SoftPos.Data.Account;
using SoftPos.Data.InventoryModel;
using SoftPos.Data.Setting;
using SQLite;

namespace SoftPos.Services
{
    public class DataCleanupService
    {
        private readonly SQLiteAsyncConnection _database;

        public DataCleanupService(SQLiteAsyncConnection database)
        {
            _database = database;
        }

        /// <summary>
        /// حذف جميع بيانات المبيعات والمشتريات والمنتجات والمدفوعات والمقبوضات
        /// </summary>
        public async Task<bool> ClearAllTransactionsAsync()
        {
            try
            {
                // حذف بيانات المبيعات
                await _database.DeleteAllAsync<SalesDetails>();
                await _database.DeleteAllAsync<SalesMaster>();
                await _database.DeleteAllAsync<SalesReturnDetails>();
                await _database.DeleteAllAsync<SalesReturnMaster>();
                
                // حذف بيانات المشتريات
                await _database.DeleteAllAsync<PurchaseDetails>();
                await _database.DeleteAllAsync<PurchaseMaster>();
                await _database.DeleteAllAsync<PurchaseReturnDetails>();
                await _database.DeleteAllAsync<PurchaseReturnMaster>();
                
                // حذف بيانات المدفوعات والمقبوضات
                await _database.DeleteAllAsync<PaymentDetails>();
                await _database.DeleteAllAsync<PaymentMaster>();
                await _database.DeleteAllAsync<ReceiptDetails>();
                await _database.DeleteAllAsync<ReceiptMaster>();
                
                // حذف بيانات المنتجات
                await _database.DeleteAllAsync<Product>();
                await _database.DeleteAllAsync<Batch>();
                
                // حذف بيانات الحركات المخزنية والمحاسبية
                await _database.DeleteAllAsync<StockPosting>();
                await _database.DeleteAllAsync<LedgerPosting>();
                
                // حذف بيانات سجل المبيعات
                await _database.DeleteAllAsync<SalesRegisterClosingBalance>();
                await _database.DeleteAllAsync<SalesRegister>();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"خطأ في حذف البيانات: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// حذف بيانات المبيعات فقط
        /// </summary>
        public async Task<bool> ClearSalesDataAsync()
        {
            try
            {
                await _database.DeleteAllAsync<SalesDetails>();
                await _database.DeleteAllAsync<SalesMaster>();
                await _database.DeleteAllAsync<SalesReturnDetails>();
                await _database.DeleteAllAsync<SalesReturnMaster>();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"خطأ في حذف بيانات المبيعات: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// حذف بيانات المشتريات فقط
        /// </summary>
        public async Task<bool> ClearPurchaseDataAsync()
        {
            try
            {
                await _database.DeleteAllAsync<PurchaseDetails>();
                await _database.DeleteAllAsync<PurchaseMaster>();
                await _database.DeleteAllAsync<PurchaseReturnDetails>();
                await _database.DeleteAllAsync<PurchaseReturnMaster>();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"خطأ في حذف بيانات المشتريات: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// حذف بيانات المنتجات فقط
        /// </summary>
        public async Task<bool> ClearProductsDataAsync()
        {
            try
            {
                await _database.DeleteAllAsync<Product>();
                await _database.DeleteAllAsync<Batch>();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"خطأ في حذف بيانات المنتجات: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// حذف بيانات المدفوعات والمقبوضات فقط
        /// </summary>
        public async Task<bool> ClearPaymentsDataAsync()
        {
            try
            {
                await _database.DeleteAllAsync<PaymentDetails>();
                await _database.DeleteAllAsync<PaymentMaster>();
                await _database.DeleteAllAsync<ReceiptDetails>();
                await _database.DeleteAllAsync<ReceiptMaster>();
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"خطأ في حذف بيانات المدفوعات: {ex.Message}");
                return false;
            }
        }
    }
}
