using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cat : Animal, IMove
    {
        public Cat(string name, int age) : base(name, age) { }

        public override string MakeSound()
        {
            return $"Meow";
        }

        public string Move()
        {
            return $"run";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Move()}";
        }
    }
}
