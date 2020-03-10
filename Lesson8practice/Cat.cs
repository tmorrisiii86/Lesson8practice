﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson8practice
{
    class Cat : Animal
    {
        public Cat(string name, bool isDangerous)
        {
            this.name = name;
            this.numOfLegs = 4;
            this.numOfArms = 0;
            this.isDangerous = isDangerous;
            this.isFurry = true;
        }

        public void Meow()
        {
            Console.WriteLine("The " + this.GetType() + " goes MEOW!");
        }

        public void AnnoyYou()
        {
            Console.WriteLine("The " + this.GetType() + " is being very annoying.");
        }

        public override int Sell()
        {
            Console.WriteLine("I will give you money if you take my cat! Here's $25 dollars!");
            return -25;
        }
    }
}
