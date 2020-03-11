using System;
using System.Collections.Generic;
using System.Text;
using LegoMinifigures.Composition.Torsos;
using LegoMinifigures.Composition.Legs;
using LegoMinifigures.Composition.Heads;

namespace LegoMinifigures
{
    class Astronaut
    {
        private string v1;
        private string v2;
        private DadBodTorso dtorso;

        // Public Property
        public Location Location { get; set; }
        // Expression Bodied Property (always readonly)
        public bool SuitedUp => Name != "Space Person";
        // Read-Only Property
        public string Name { get; }
        // Public property with a private setter
        public string Job { get; private set; }
        public int OxygenLevel { get; set; }


        public AstronautTorso Torso { get; set; }
        public AstronautLegs Legs { get; set; }
        public ZoeHead Head { get; set; }

        public Astronaut(string name, string job,
                        ZoeHead head, AstronautTorso torso,
                        AstronautLegs legs)
        {
            Name = name;
            Job = job;

            Head = head;
            Torso = torso;
            Legs = legs;
        }

        public Astronaut(string v1, string v2, ZoeHead head, DadBodTorso dtorso, AstronautLegs legs)
        {
            this.v1 = v1;
            this.v2 = v2;
            Head = head;
            this.dtorso = dtorso;
            Legs = legs;
        }

        public void Promote()
        {
            Job = "Commander of Janitors";
        }

        public void DoYourJob(int stepsToWalk)
        {
            Console.WriteLine($"{Name} is doing all of their {Job} duties...");
            Legs.Walk(stepsToWalk);
            Head.EatPie("Cherry");
            Torso.Flex();
            Legs.Walk(stepsToWalk);
        }
    }
}
