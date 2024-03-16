using PickRandomCards;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number to pick: ");
        string line = Console.ReadLine();

        if (int.TryParse(line, out int numberOfCards))
        {
            foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                Console.WriteLine(card);
        }
        else
        {
            Console.Write("Number was not valid!");
        }
    }
}