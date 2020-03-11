using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{   // the colon acts as the extends keyword from React; these items exist in 
    // TorsoBase so we reference it; the colon creates an "Is A" relationship
    class AstronautTorso : TorsoBase
    {
        public int NumberOfArms { get; set; }
        // override says that the base class indicates that I have to have something that looks like this
        public override void Flex()
        {
            if(ChiseledAbs && !Shirted)
            {
                Console.WriteLine("Check out my sick abs.");
            }
            else if(HandType == HandType.XBuster)
            {
                Console.WriteLine("Welcome to the gun show. Pew Pew!");
            }
            else
            {
                Console.WriteLine("Weird flex, but ok.");
            }
        }

        public override void Breathe()
        {
            base.Breathe();

            Console.WriteLine("Exhale, Inhale..");
        }

    }
}
