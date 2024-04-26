using System.Collections.Specialized;

namespace WorkingWithEFCore.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId {  get; set; }
        public Customer Customer { get; set; } = null!;
        public ICollection<OrderedDetail> OrderedDetails { get; set; } = null!;
    }
}