internal class Program
{
    private static void Main(string[] args)
    {
        Guy.Guy joe = new Guy.Guy() { Cash = 50, Name = "Joe" };
        Guy.Guy bob = new Guy.Guy() { Cash = 100, Name = "Bob" };

        while (true)
        {
            Console.Write("Enter an amount: ");
            string howMuch = Console.ReadLine();
            if (howMuch == "") return;
            if (int.TryParse(howMuch, out int amount))
            {
                Console.Write("Who should give the cash:");
                string whichGuy = Console.ReadLine();
                if (whichGuy == "Joe")
                {
                    int cashGiven = joe.GiveCash(amount);
                    bob.ReceiveCash(cashGiven);
                }
                else if (whichGuy == "Bob")
                {
                    int cashGiven = bob.GiveCash(amount);
                    joe.ReceiveCash(cashGiven);
                }
                else
                {
                    Console.WriteLine("Please enter 'Joe' or 'Bob'");
                }
            }
            else
            {
                Console.WriteLine("Please enter an amount (or a black line to exit.)");
            }
        }
    }
}
