using SQLite;

namespace SoftPos.Data.InventoryModel
{
    public class ReceiptDetails
    {
        [PrimaryKey, AutoIncrement]
        public int ReceiptDetailsId { get; set; }
        public int ReceiptMasterId { get; set; }
        public int SalesMasterId { get; set; }
        public int LedgerId { get; set; }
        public decimal Amount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal ReceiveAmount { get; set; }
        public decimal DueAmount { get; set; }
        public string Narration { get; set; } = string.Empty;
    }
}