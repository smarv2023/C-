using System;
using System.Collections.Generic;

namespace ConnectToDB.Models;

public partial class Book
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Author { get; set; }

    public int? PublicationYear { get; set; }

    public double? Price { get; set; }
}
