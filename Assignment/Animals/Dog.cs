
namespace Animals
{
    internal class Dog : Animal, IMove
    {
        public Dog(string name, int age) : base(name, age) { }
        public override string MakeSound()
        {
            return $"Woof woof";
        }

        public string Move()
        {
            return $"walk";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Move()}";
        }
    }
}
