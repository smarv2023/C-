using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using ConnectToDB.Models;

Address address = new Address();

var addressID = 1;

using (var ctx = new BooksContext())
{
    address = ctx.Addresses.SingleOrDefault(x => x.AddressId == addressID);
}

Console.WriteLine(address.FirstName);
Console.WriteLine(address.LastName);
Console.WriteLine(address.Email);
Console.WriteLine(addressID);


