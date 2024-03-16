using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {   
        static Random random = new Random();
        /// <summary>
        /// Pick a number of cards and returns them.
        /// </summary>
        /// <param name="numberOfCards">The number of cards to pick.</param>
        /// <returns>An array of string that contain the card name.</returns>
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        /// <summary>
        /// Generate random suits
        /// </summary>
        /// <returns>An random value equivalent suit.</returns>
        private static string RandomSuit()
        {
            int value = random.Next(1, 5);

            if (value == 1) return "Spades";
            if (value == 2) return "Hearts";
            if (value == 3) return "Clubs";

            return "Diamonds";
        }
        /// <summary>
        /// Generate random value of card.
        /// </summary>
        /// <returns>Generated value.</returns>
        private static string RandomValue()
        {
            int value = random.Next(1, 14);

            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            // value is declare as int so I need to convert this to string, to return
            return value.ToString();
        }
    }
}
