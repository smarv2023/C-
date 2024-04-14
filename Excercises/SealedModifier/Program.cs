namespace SealedModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrdinaryHuman marvin = new OrdinaryHuman(185);

            // calling extension method
            Console.WriteLine(marvin.BreakWalls(92.5));
        }
    }
}
