using WorkingWithEFCore.Data;
using WorkingWithEFCore.Models;

using WorkingWithEfcoreContext context = new WorkingWithEfcoreContext();

foreach (Customer c in context.Customers)
{
    Console.WriteLine($"Full Name: {c.FirstLast} ");
}