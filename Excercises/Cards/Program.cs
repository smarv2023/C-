namespace Cards
{
    internal class Program
    {
        private static readonly Random random1 = new Random();

        static Card RandomCard()
        {
            return new Card((Values)random1.Next(1, 14), (Suits)random1.Next(4));
        }

        static void PrintCards1(List<Card> cards)
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int suitNumber = random.Next(4);
            int valueNumber = random.Next(1, 14);
            int anyRandomInt = random.Next();

            Card myCard = new Card((Values)valueNumber, (Suits)suitNumber);
            Deck myDeck = new Deck();

            Console.WriteLine(myCard.Name+ " Selected");
            myDeck.PrintCards();

            /// List
            List<Card> cards = new List<Card>();
            Console.Write("Enter number of cards: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfCards))
                for (int i = 0; i < numberOfCards; i++)
                    cards.Add(RandomCard());

            PrintCards1(cards);

            cards.Sort(new CardComparerByValue());
            Console.WriteLine("\n... sorting the cards ...\n");

            PrintCards1(cards);
        }
    }
}
