﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalculate
    {
        void Addition();

        void Subtraction();

        void Multiplication();

        void Division();

        void Equal(string operation);

        void Clear();
    }
}
