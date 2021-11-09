using AbstractClassExample.Models;
using System;

namespace AbstractClassExample
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");

                //SuperHero superHero = new();

                SuperMan superMan = new SuperMan();
                superMan.Fly();
                superMan.LookThroughObjects();

                Sword sword = new Sword("BatSword");
                sword.TakeDamage(5);
            }
        }
   }


