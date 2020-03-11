using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Legs
{
    class BabyLegs
    {
        // these are properties
        public bool CanWalk { get; set; }
        public int NumberOfRolls { get; set; }
        // Expression bodied property
        public bool IsClumsy => true;
        public bool HasPants { get; set; }

        public void Walk(int steps)
        {
            if(CanWalk)
            {
                Console.WriteLine($"Baby legs walk around {steps} steps.");
            }
            else
            {
                Console.WriteLine($"Baby legs crawl {steps} feet.");
            }
        }

        public void Kick()
        {
            Console.WriteLine($"Baby legs kick with {NumberOfRolls} fat rolls.");
        }
    }
}
