using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Composition.Heads
{
    class ZoeHead
    {
        public bool Helmeted { get; set; }
        public string FacialExpression { get; set; }
        public LegoColor Color { get; set; }
        public LegoColor EyeColor { get; set; }

        public void Talk()
        {
            Console.WriteLine($"Zoe says 'Tell my wife I love her very much.' While {FacialExpression} emphatically.");
        }

        public void EatPie(string typeOfPie)
        {
            if (typeOfPie == "apple")
                Console.WriteLine("MMM.. Pie");
            else
                Console.WriteLine("This is not pie.");
        }
    }
    // enums are lists
    enum LegoColor
    {
        Yellow,
        Red,
        Green,
        White,
        Grey,
        Blue,
        Black,
        Orange
    }
}
