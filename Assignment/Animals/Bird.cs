using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Bird : Animal, IMove
    {
        public Bird(string name, int age) : base(name, age) { }
        public override string MakeSound()
        {
            return $"Tweet tweet";
        }

        public string Move()
        {
            return $"fly";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Move()}";
        }
    }
}
