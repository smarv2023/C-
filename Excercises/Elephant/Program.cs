namespace Elephant
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            while (true)
            {
                Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input);

                if (input == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (input == '3')
                {
                    Elephant tempHolder;
                    tempHolder = lloyd;
                    lloyd = lucinda;
                    lucinda = tempHolder;

                    Console.WriteLine("References have been swapped");
                }
                else if (input == '4')
                {
                    lloyd = lucinda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else if (input == '5') 
                {
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                }
                else return;
                Console.WriteLine();
            }
        }
    }
}