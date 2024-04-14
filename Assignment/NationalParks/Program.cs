namespace NameParks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Park acadia = new Park("Acadia", "State Maine", "National", "Hiking, Biking", 20, 240, 4100000, 20000000);

            Park yulie = new Park("Yulie", "State Wyoming", "National", "Camping", 3);

            Park winnipeg = new Park();

            Park justPark = new Park();

            Console.Write(acadia);
            Console.WriteLine("Annual revenue: {0}", acadia.Revenue().ToString("C"));
            Console.WriteLine("Cost per visitor: {0}", acadia.CostPerVisitor().ToString("C"));

            Console.WriteLine("\n");

            // Number of Employee, Number of Visitor, Annual budget is the only accessible directly
            yulie.NumberOfEmployee = 500;
            yulie.NumberOfVisitor = 100000;
            yulie.AnnualBudget = 100000;
            Console.Write(yulie);

            Console.WriteLine("\n");

            winnipeg.Name = "Winnipeg Park";
            winnipeg.Location = "Winnipeg";
            winnipeg.TypeOfPark = "Local";
            Console.Write(winnipeg);

            Console.WriteLine("\n");

            justPark.Name = "Just Park";
            justPark.NumberOfEmployee = 50;
            justPark.NumberOfVisitor = 2000000;
            justPark.AnnualBudget = 1000000;
            justPark.Price = 5;
            Console.Write(justPark);
            Console.WriteLine("Annual revenue: {0}", justPark.Revenue().ToString("C"));
            Console.WriteLine("Cost per visitor: {0}", justPark.CostPerVisitor().ToString("C"));

            Console.ReadLine();
        }
    }
}
