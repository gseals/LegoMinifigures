using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var astronaut = new Astronaut("Space Person", "Janitor");
            var astronaut2 = new Astronaut("Space Lady", "Janitor");

            astronaut.DoYourJob();

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
