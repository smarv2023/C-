namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int suitNumber = random.Next(4);
            int valueNumber = random.Next(1, 14);
            int anyRandomInt = random.Next();

            Card myCard = new Card((Values)valueNumber, (Suits)suitNumber);
            Deck myDeck = new Deck();

            Console.WriteLine(myCard.Name + " Selected");
            myDeck.PrintCards();
        }
    }
}
