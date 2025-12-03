using SQLite;
using System.ComponentModel.DataAnnotations;
using MaxLengthAttribute = System.ComponentModel.DataAnnotations.MaxLengthAttribute;

using SoftPos.Utilities;
namespace SoftPos.Data.InventoryModel
{
    public class ExpenseCategory
    {
        [PrimaryKey, AutoIncrement]
        public int ExpenseCategoryId { get; set; }

        [Required]
        [MaxLength(255)]
        public string CategoryName { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string CategoryType { get; set; } // "Employee", "Owner", "Waste", "Other"

        public bool IsActive { get; set; } = true;

        public DateTime AddedDate { get; set; } = DateTimeHelper.Now;
        public DateTime? ModifyDate { get; set; }
    }
}











