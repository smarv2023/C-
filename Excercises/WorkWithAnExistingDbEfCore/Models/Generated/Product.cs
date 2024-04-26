using System;
using System.Collections.Generic;

namespace WorkingWithEFCore.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<OrderedDetail> OrderedDetails { get; set; } = new List<OrderedDetail>();
}
