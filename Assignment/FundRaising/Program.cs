using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        const double PRICE_PER_BAR = 1.5;
        const double ASSOCIATION_FEE_RATE = 0.10;
        const double WHOLESALE_COST_PER_CASE = 100.00;
        const int BARS_PER_CASE = 100;

        int caseSold, barsSold;

        double grossSales, studentGovAssociation, productCost, grossIncome, netIncome;

        caseSold = 29;
        barsSold = caseSold * BARS_PER_CASE;
        productCost = barsSold * (BARS_PER_CASE / WHOLESALE_COST_PER_CASE);
        grossSales = barsSold * PRICE_PER_BAR;
        grossIncome = grossSales - productCost;
        studentGovAssociation = grossIncome * ASSOCIATION_FEE_RATE;
        netIncome = grossIncome - studentGovAssociation;

        Console.WriteLine("{0, 22}\n", "Granola Bar Sales");
        Console.WriteLine("{0, -15} {1, 10:d}", "Case Sold: ", caseSold);
        Console.WriteLine("{0, -15} {1, 10:c}", "Gross Sales: ", grossSales);
        Console.WriteLine("{0, -15} {1, 10:c}", "Product Cost: ", productCost);
        Console.WriteLine("{0, -15} {1, 10:c}", "SGA Fees: ", studentGovAssociation);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("{0, -15} {1, 10:c}", "Net Profit: ", netIncome);
        Console.WriteLine("In Summary:\nThe cost expenses is: " + productCost.ToString("C3", CultureInfo.CurrentCulture)
            + " and the earnings is: " + netIncome.ToString("C", CultureInfo.CurrentCulture));
    }
}