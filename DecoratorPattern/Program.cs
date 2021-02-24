using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage coffee = new Coffee();
            coffee = new CaramelSyrup(coffee, 2);
            coffee = new MochaShot(coffee, 1);
            Console.WriteLine($"{coffee.Description} for ${coffee.Cost()}");        }
    }
}