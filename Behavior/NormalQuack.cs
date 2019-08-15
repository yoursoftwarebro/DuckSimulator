using System;

namespace DuckSimulator.Behavior
{
    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
