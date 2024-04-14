using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedModifier
{
    sealed class OrdinaryHuman
    {
        private int age;
        int weight;

        public OrdinaryHuman(int weight)
        {
            this.weight = weight;
        }

        public void GoToWork() { /* code to go to work */}
        public void PayBills() { /* code to pay the bills */}
    }

    static class AmazeballsSerum
    {
        public static string BreakWalls(this OrdinaryHuman h, double wallDensity)
        {
            return ($"I broke through a wall of {wallDensity} density.");
        }
    }
}
