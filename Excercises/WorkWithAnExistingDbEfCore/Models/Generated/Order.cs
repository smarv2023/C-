using System;
using System.Collections.Generic;

namespace WorkingWithEFCore.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderPlaced { get; set; }

    public DateTime? OrderFulfilled { get; set; }

    public int CustomerId { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual ICollection<OrderedDetail> OrderedDetails { get; set; } = new List<OrderedDetail>();
}
