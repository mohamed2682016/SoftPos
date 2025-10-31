using SQLite;

namespace SoftPos.Data.InventoryModel
{
    public class SalesRegisterClosingBalance
    {
        [PrimaryKey, AutoIncrement]
        public int SalesRegisterClosingBalanceId { get; set; }
        public int Id { get; set; }
        public int SalesRegisterId { get; set; }
        public int PaymentMethodId { get; set; }
        public decimal Amount { get; set; }
        public int SalesMasterId { get; set; }
        public int VoucherTypeId { get; set; }
        public decimal PayLater { get; set; }
        public decimal CreditAppliedAmount { get; set; }
        public decimal SalesReturnAmount { get; set; }
        public decimal CashReturnAmount { get; set; }
        public decimal ClosingAmount { get; set; }
        public decimal ExpenseAmount { get; set; }
        public decimal PurchasePayment { get; set; }
        public decimal CashLeftinDrawer { get; set; }
        public decimal PhysicalDrawer { get; set; }
        public DateTime AddedDate { get; set; }
    }
}