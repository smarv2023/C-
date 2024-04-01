using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes
{
    internal class Shoe
    {
        public Style Style
        {
            get; private set;
        }

        public Color Color
        {
            get; private set;
        }

        public Shoe(Style style, Color color)
        {
            Style = style;
            Color = color;
        }

        public string Description
        {
            get { return $"A {Color} {Style}"; }
        }
    }
}
