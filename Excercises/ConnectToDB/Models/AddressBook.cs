using System;
using System.Collections.Generic;

namespace ConnectToDB.Models;

public partial class AddressBook
{
    public int AddressId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Street { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;
}
