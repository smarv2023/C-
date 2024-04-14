using System.Collections.Generic;
using System.Linq;

namespace LINQSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listOfObjects = new List<PrintWhenGetting>();
            for (int i = 1; i < 5; i++)
                listOfObjects.Add(new PrintWhenGetting() { InstanceNumber = i });

            Console.WriteLine("Set up the query");
            var result =
                from o in listOfObjects
                select o.InstanceNumber;

            // Notice how the Console.WriteLine that prints "Set up the query" runs before the get accessor ever executes.
            // That’s because the LINQ query won’t get executed until the foreach loop.
            Console.WriteLine("Run the foreach");
            foreach (var number in result)
                Console.WriteLine($"Writing #{number}");

            Console.WriteLine();
            // Add this line, and change the foreach to use the new List:
            var immediate = result.ToList();

            Console.WriteLine("Run the foreach");
            foreach (var number in immediate)
                Console.WriteLine($"Writing #{number}");
        }
    }
    class PrintWhenGetting
    {
        private int instanceNumber;
        public int InstanceNumber
        {
            set { instanceNumber = value; }
            get
            {
                Console.WriteLine($"Getting #{instanceNumber}");
                return instanceNumber;
            }
        }
    }
}
