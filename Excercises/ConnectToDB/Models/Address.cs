using System;
using System.Collections.Generic;

namespace ConnectToDB.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;
}
