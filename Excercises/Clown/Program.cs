﻿namespace Clown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClown.CardCapacity = 18;
            Console.WriteLine(IClown.ClownCarDescription());

            IClown fingersTheClown = new ScaryScary("big red nose", 14);
            fingersTheClown.Honk();
            if (fingersTheClown is IScaryClown iScaryClownReference)
            {
                iScaryClownReference.ScareLittleChildren();
            } 
        }
    }
}
