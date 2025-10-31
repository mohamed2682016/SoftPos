using SQLite;
using System.ComponentModel.DataAnnotations;
using MaxLengthAttribute = System.ComponentModel.DataAnnotations.MaxLengthAttribute;

using SoftPos.Utilities;
namespace SoftPos.Data.InventoryModel
{
    public class Waste
    {
        [PrimaryKey, AutoIncrement]
        public int WasteId { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public decimal Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public DateTime WasteDate { get; set; }

        [MaxLength(50)]
        public string WasteType { get; set; } // "Expired", "Damaged", "Stolen", "Other"

        [MaxLength(500)]
        public string Reason { get; set; }

        [MaxLength(100)]
        public string Reference { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; }

        public int? WarehouseId { get; set; }
        public int? UserId { get; set; } // Who recorded the waste

        public bool IsApproved { get; set; } = false;
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public DateTime AddedDate { get; set; } = DateTimeHelper.Now;
        public DateTime? ModifyDate { get; set; }
    }
}











