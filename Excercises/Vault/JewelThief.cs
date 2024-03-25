﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vault
{
    internal class JewelThief : Locksmith
    {
        private string stolenJewels;
        protected override void ReturnContents(string safeContents, SafeOwner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine($"I'm stealing the jewels! I stole: {stolenJewels}");
        }
    }
}
