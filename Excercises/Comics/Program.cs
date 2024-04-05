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

        foreach (var i in mostExpensive)
        {
            Console.WriteLine($"{i} is worth {Comic.Prices[i.Issue]:c}");
        }
    }
}