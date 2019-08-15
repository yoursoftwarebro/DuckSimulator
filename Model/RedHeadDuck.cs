using DuckSimulator.Behavior;
using System;

namespace DuckSimulator.Model
{
    internal class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("\nI am a Red Head Duck");
        }
    }
}