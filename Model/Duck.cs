using DuckSimulator.Behavior;
using System;

namespace DuckSimulator.Model
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck()
        {

        }

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
