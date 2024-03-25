﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    internal class BrokenEgg : Egg
    {
        public BrokenEgg(string color) : base (0, $"broken {color}")
        {
            Console.WriteLine("A bird laid a broken egg");
        }
    }
}
