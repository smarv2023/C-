using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Cards
{
    internal class Card
    {
        public Suits Suit {  get; private set; }

        public Values Value { get; private set; }

        public Card(Values Value, Suits Suit)
        {
            this.Value = Value;
            this.Suit = Suit;
        }

        public string Name { get {  return $"{Value} of {Suit}"; } }

        public override string ToString()
        {
            return Name;
        }
    }
}
