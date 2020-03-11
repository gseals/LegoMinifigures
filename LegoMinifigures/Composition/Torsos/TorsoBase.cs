using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Torsos
{
    abstract class TorsoBase
    {
        public abstract bool ChiseledAbs { get; }
        public bool Shirted { get; set; }
        public HandType HandType { get; set; }

        //there are no instructions as to what this thing does
        public abstract void Flex();

        public virtual void Breathe()
        {
            Console.WriteLine("Inhale, Exhale...");
        }
    }
}
