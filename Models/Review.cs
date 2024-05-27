using System;
using System.ComponentModel.DataAnnotations;

namespace CLDV_Part_2.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; } = DateTime.Now;
    }
}
