using System.Security.Cryptography.X509Certificates;

namespace Dogs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canine spot = new Canine("Spot", "pug");
            Canine bob = spot;
            bob.Name = "Spike";
            bob.Breed = "beagle";
            spot.Speak();
            bob.Speak();

            Dog jake = new Dog("Jake", "poodle");
            Dog betty = jake;
            betty.Name = "Betty";
            betty.Breed = "pit bull";
            jake.Speak();
            betty.Speak();

            SpeakThreeTimes(jake);
        }

        public static void SpeakThreeTimes(Dog dog)
        {
            for (int i = 0; i < 5; i++)
            {
                dog.Speak();
            }
        }
    }

    struct Dog
    { 
        public string Name { get; set; }
        public string Breed { get; set; }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public void Speak()
        {
            Console.WriteLine("Dog: My name is {0} and I'm a {1}.", Name, Breed);
        }
    }

    class Canine
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public Canine(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public void Speak()
        {
            Console.WriteLine("Canine: My name is {0} and I'm a {1}.", Name, Breed);
        }
    }
}
