using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    internal class Pigeon : Bird
    {
        public override Egg[] LayEggs(int numberOfEggs)
        {
            // array instance = number of array
            Egg[] eggs = new Egg[numberOfEggs];
           
            for (int i = 0; i < eggs.Length; i++)
            {
                if (Bird.Randomizer.Next(4) == 0)
                    eggs[i] = new BrokenEgg("white");
                else
                    eggs[i] = new Egg(Bird.Randomizer.NextDouble() * 2 + 1, "white");
            }
            return eggs;
        }
    }
}

