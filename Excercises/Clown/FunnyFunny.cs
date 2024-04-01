﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clown
{
    internal class FunnyFunny : IClown
    {
        private string funnyThingIHave;

        public string FunnyThingIHave { get { return funnyThingIHave; } }

        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public void Honk()
        {
            Console.WriteLine($"Hi kids! I have a { funnyThingIHave}.");
        }
    }
}
