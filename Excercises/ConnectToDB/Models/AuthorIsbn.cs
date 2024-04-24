using System;
using System.Collections.Generic;

namespace ConnectToDB.Models;

public partial class AuthorIsbn
{
    public int AuthorId { get; set; }

    public string Isbn { get; set; } = null!;

    public virtual Author Author { get; set; } = null!;

    public virtual Title IsbnNavigation { get; set; } = null!;
}
