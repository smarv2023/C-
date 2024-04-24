/*
    This is a divider calculator, it will collect user input of dividend and divisor.
 */

while (true)
{
    try
    {
        Console.WriteLine("\n\t\t\tCalculator Division");
        decimal dividend = CollectingNumber("1st");
        Console.WriteLine();

        decimal divisor = CollectingNumber("2nd");
        decimal result = dividend / divisor;

        Console.WriteLine($"{dividend} / {divisor} = {result}");
    }
    catch (DivideByZeroException dE)
    {
        Console.WriteLine("Error: " + dE.Message + "\nPlease try again");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

    Console.Write("\nDo you still want to continue dividing? Y to continue: ");
    string continueYorN = (Console.ReadLine()).ToUpper();
    if (continueYorN != "Y")
        break;
}

Console.WriteLine("Thank you for using the Division Calculator!");
Console.ReadKey();

// Function to collect number and validate the input
decimal CollectingNumber(string number)
{
    while (true)
    {
        try
        {
            Console.Write($"Enter {number} number: ");
            decimal input = decimal.Parse(Console.ReadLine());
            return input;
        }
        catch (FormatException fE)
        {
            Console.WriteLine("Error: " + fE.Message + "\nPlease enter valid number\n");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
