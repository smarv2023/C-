namespace Birds
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Bird bird;
            Console.Write("\nPress P for pigeon, O for ostrich: ");
            char key = Char.ToUpper(Console.ReadKey().KeyChar);
            if (key == 'P') 
                bird = new Pigeon();
            else if (key == 'O') 
                bird = new Ostrich();
            else return;

            Console.Write("\nHow many eggs should it lay? ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfEggs)) return;
            Egg[] eggs = bird.LayEggs(numberOfEggs);
            foreach (Egg egg in eggs)
            {
                Console.WriteLine(egg.Description);
            }

            // List
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 13 },
            };

            IEnumerable<Bird> upcastDucks = ducks;
            Bird.FlyAway(upcastDucks.ToList(), "Minnesota");
        }
    }
}
