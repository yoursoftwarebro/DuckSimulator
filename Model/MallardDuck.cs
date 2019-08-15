using DuckSimulator.Behavior;
using System;

namespace DuckSimulator.Model
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("\nI am a Mallard Duck");
        }
    }
}