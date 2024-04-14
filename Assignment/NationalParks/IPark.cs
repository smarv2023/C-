using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameParks
{
    internal interface IPark
    {
        decimal Revenue();
        decimal CostPerVisitor();
    }
}
