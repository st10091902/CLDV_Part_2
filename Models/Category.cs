using System;
using System.ComponentModel.DataAnnotations;

namespace CLDV_Part_2.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
