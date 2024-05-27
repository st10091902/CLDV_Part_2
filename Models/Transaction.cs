using System;
using System.ComponentModel.DataAnnotations;

namespace CLDV_Part_2.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
    }
}
