using System;
using System.Collections.Generic;

namespace ConnectToDB.Models;

public partial class Title
{
    public string Isbn { get; set; } = null!;

    public string Title1 { get; set; } = null!;

    public int EditionNumber { get; set; }

    public string Copyright { get; set; } = null!;
}
