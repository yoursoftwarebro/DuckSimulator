using DuckSimulator.Model;

namespace DuckSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.Display();
            duck.PerformFly();
            duck.PerformQuack();

            duck = new RubberDuck();
            duck.Display();
            duck.PerformFly();
            duck.PerformQuack();
        }
    }
}
