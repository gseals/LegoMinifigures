using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torsos;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate
            var head = new ZoeHead
            {
                FacialExpression = "Smiling",
                Color = LegoColor.Orange,
                EyeColor = LegoColor.Green,
                Helmeted = true
            };

            var legs = new AstronautLegs
            {
                HasPants = true,
                Shoes = ShoeType.FlipFlops
            };

            var torso = new AstronautTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                NumberOfArms = 3,
                Shirted = true
            };

            var astronaut = new Astronaut("Space Person", "Janitor", head, torso, legs);
            var astronaut2 = new Astronaut("Space Lady", "Janitor", head, torso, legs);

            astronaut.DoYourJob(100);

            var casper = new Ghost("Casper", DateTime.Today)
            {
                Friendly = true,
            };

            casper.Spook();
            casper.Haunt("Whipstaff Manor");
            casper.Spook();

            var fatso = new Ghost("Fatso", new DateTime(1924, 12, 1))
            {
                Friendly = false,
            };
        }
    }
}
