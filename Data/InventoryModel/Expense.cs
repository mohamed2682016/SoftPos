using SQLite;
using System.ComponentModel.DataAnnotations;
using MaxLengthAttribute = System.ComponentModel.DataAnnotations.MaxLengthAttribute;

using SoftPos.Utilities;
namespace SoftPos.Data.InventoryModel
{
    public class Expense
    {
        [PrimaryKey, AutoIncrement]
        public int ExpenseId { get; set; }

        [Required]
        [MaxLength(255)]
        public string ExpenseName { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime ExpenseDate { get; set; }

        [Required]
        public int ExpenseCategoryId { get; set; }

        [MaxLength(50)]
        public string ExpenseType { get; set; } // "Employee", "Owner", "Waste", "Other"

        [MaxLength(100)]
        public string Reference { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; }

        public int? EmployeeId { get; set; } // For employee expenses
        public int? WarehouseId { get; set; } // For warehouse-specific expenses
        public int? UserId { get; set; } // Who created the expense

        public bool IsApproved { get; set; } = false;
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public DateTime AddedDate { get; set; } = DateTimeHelper.Now;
        public DateTime? ModifyDate { get; set; }
    }
}











