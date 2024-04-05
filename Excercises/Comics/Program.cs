﻿using Comics;
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

        foreach (Comic comic in mostExpensive)
        {
            Console.WriteLine($"{comic} is worth {Comic.Prices[comic.Issue]:c}");
        }
    }
}