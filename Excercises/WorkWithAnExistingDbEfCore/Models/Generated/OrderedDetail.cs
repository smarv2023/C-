﻿using System;
using System.Collections.Generic;

namespace WorkingWithEFCore.Models;

public partial class OrderedDetail
{
    public int Id { get; set; }

    public int Quantity { get; set; }

    public int ProductId { get; set; }

    public int OrderId { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
