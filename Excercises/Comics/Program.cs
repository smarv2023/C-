using Comics;
using System.Collections.Generic;
using System.Linq;


internal class Program
{
    private static void Main(string[] args)
    {
        IEnumerable<Comic> mostExpensive =
        from comic in Comic.Catalog
        where Comic.Prices[comic.Issue] > 500
        orderby -Comic.Prices[comic.Issue]
        select comic;

        foreach (Comic i in mostExpensive)
        {
            Console.WriteLine($"{i} is worth {Comic.Prices[i.Issue]:c}");
        }

        // stand alone LINQ program
        var sandwiches = new[] { "ham and cheese", "salami with mayo", "turkey and swiss", "chicken cutlet" };

        var sandwichesOnRye =
            from sandwich in sandwiches
            select $"{sandwich} on rye";

        foreach (var sandwich in sandwichesOnRye)
            Console.WriteLine(sandwich);

        // Chaining
        Console.WriteLine();
        AddSubtract a = new AddSubtract() { Value = 5 }.Subtract(3);
        Console.WriteLine($"Result: {a.Value}");
        Console.WriteLine();
        AddSubtract b = new AddSubtract() { Value = 5 }.Add(3);
        Console.WriteLine($"Result: {b.Value}");
    }

    class AddSubtract
    {
        public int Value { get; set; }

        public AddSubtract Subtract(int i)
        {
            Console.WriteLine($"Value: {Value}, subracting {i}");

            return new AddSubtract()
            {
                Value = Value - i
            };
        }

        public AddSubtract Add(int i)
        {
            Console.WriteLine($"Value: {Value}, add {i}");

            return new AddSubtract()
            {
                Value = Value + i
            };
        }
    }
}
