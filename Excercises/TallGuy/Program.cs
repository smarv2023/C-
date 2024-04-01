using System.Xml.Linq;

namespace TallGuy
{

    class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public void TalkAboutYourSelf()
        {
            Console.WriteLine($"My name is {Name} and I’m {Height} inches tall.");
        }

        public string FunnyThingIHave
        {
            get { return "big shoes"; }
        }

        public void Honk()
        {
            Console.WriteLine("Honk honk");
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy" };
            tallGuy.TalkAboutYourSelf();
            Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
            tallGuy.Honk();
        }
    }

}
