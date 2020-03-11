using LegoMinifigures.Composition.Heads;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Torsos;
using System;
using System.Collections.Generic;

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

            var dtorso = new DadBodTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                Shirted = true
            };

            var atorso = new AstronautTorso
            {
                HandType = HandType.Baby,
                ChiseledAbs = true,
                Shirted = true
            };

            atorso.Breathe();
            dtorso.Breathe();

            var astronaut = new Astronaut("Space Person", "Janitor", head, atorso, legs);
            var astronaut2 = new Astronaut("Space Lady", "Janitor", head, dtorso, legs);

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


            var torsos = new List<TorsoBase>();
            torsos.Add(dtorso);
            torsos.Add(atorso);

            foreach (var torso in torsos)
            {
                torso.Breathe();
                torso.Flex();
            }

        }
    }
}
