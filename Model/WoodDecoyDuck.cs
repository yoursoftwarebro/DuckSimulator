using DuckSimulator.Behavior;
using System;

namespace DuckSimulator.Model
{
    public class WoodDecoyDuck : Duck
    {
        public WoodDecoyDuck()
        {
            flyBehavior = new FlyNoWings();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("\nI am a Wooden Decoy Duck");
        }
    }
}