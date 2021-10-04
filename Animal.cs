﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestPolimorfizm
{
    class Animal
    {
        public string Name { get; set; }

        public virtual void GetRoar()
        {
            Console.WriteLine("WAAA");
        }
    }

    class Cat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("MEOW");
        }
    }

    class Dog : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("WUF");
        }
    }

    class Rat : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("FR FR");
        }
    }

    class Boozer : Animal
    {
        public override void GetRoar()
        {
            Console.WriteLine("OOOOOOOO");
        }
    }


}
