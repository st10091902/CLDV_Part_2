using Fluent.Infrastructure.FluentModel;

namespace CLDV_Part_2.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsProcessed { get; set; }

        public Product Product { get; set; }
        public ApplicationUser User { get; set; }
    }
}
