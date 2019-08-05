using System;

using Design_Decorator.Concrete;
using Design_Decorator.Interfaces;

namespace Design_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICoffee myCoffee = new Chocolate(new Milk(new Americano()));
            Console.WriteLine($"My coffee cost (with milk & chocolate): {myCoffee.Cost()}");

        }
    }
}
