﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HippoAndWolf
{
    internal abstract class Canine : Animal
    {
        public bool BelongsToPack { get; protected set; } = false;
    }
}
