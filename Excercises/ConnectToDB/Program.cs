using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using ConnectToDB.Models;

Address address = new Address();

var addressID = 2;

using (BooksContext ctx = new BooksContext())
{
    address = ctx.Addresses.SingleOrDefault(x => x.AddressId == addressID);
}

Console.WriteLine(address.FirstName);
Console.WriteLine(address.LastName);
Console.WriteLine(address.Email);
Console.WriteLine(addressID);


// Better approach
BooksContext context = new BooksContext();
var books = from book in context.Books orderby book.Author select book;

foreach (Book b in books)
{
    Console.WriteLine($"Id:             {b.Id}");
    Console.WriteLine($"Title:          {b.Title}");
    Console.WriteLine($"Author:         {b.Author}");
    Console.WriteLine($"Publication:    {b.PublicationYear}");
    Console.WriteLine($"Author:         {b.Author}");
    Console.WriteLine(new string('-', 20));
}

