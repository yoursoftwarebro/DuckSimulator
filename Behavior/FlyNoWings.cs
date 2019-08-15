using System;

namespace DuckSimulator.Behavior
{
    public class FlyNoWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
