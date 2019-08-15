using DuckSimulator.Behavior;
using System;

namespace DuckSimulator.Model
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWings();
            quackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("\nI am a Rubber Duck");
        }
    }
}