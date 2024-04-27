using WorkingWithEFCore.Data;
using WorkingWithEFCore.Models;

using WorkingWithEFCoreContext context = new WorkingWithEFCoreContext();


// Add data
/*
Product veggieSpecial = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 9.99M
};
context.Products.Add(veggieSpecial);
*/



//LINQ Expression
var products = context.Products
    .Where(p => p.Price > 10.00M)
    .OrderBy(p => p.Name);

/*
var products = from product in context.Products 
               where product.Price > 10.00M 
               orderby product.Name select product;
*/
foreach (Product p in products)
{
    Console.WriteLine($"Id:     {p.Id}");
    Console.WriteLine($"Name:   {p.Name}");
    Console.WriteLine($"Price:  {p.Price}");
    Console.WriteLine(new string('-', 20));
}
