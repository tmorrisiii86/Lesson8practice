using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8practice
{
    class Fish : Animal
    {
        private int gils = 2;

        public Fish(bool isDangerous)
        {
            name = "Freddy the Fish";
            numOfLegs = 0;
            numOfArms = 0;
            isFurry = false;
            this.isDangerous = isDangerous;
        }

        public override void Breath()
        {
            Console.WriteLine("The fish breathes through it's gills!");
        }

        public override int Sell()
        {
            Console.WriteLine("I'll sell my fish for $5 dollars.");
            return 5;
        }
    }
}
