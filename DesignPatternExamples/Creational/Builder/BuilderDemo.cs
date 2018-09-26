using System;
using DesignPatternExamples.Structural.Decorator;

namespace DesignPatternExamples.Creational.Builder
{
    public class BuilderDemo
    {
        public void Run()
        {
            IBeverage espresso = new Waiter(new CoffeeBuilder()).GetEspressoWithMilk();
            Console.WriteLine($"{espresso.GetDescription()} = {espresso.GetAmount()} RSD");

            var coffee = new Waiter(new CoffeeBuilder()).GetCoffeeWithDiscount();
            Console.WriteLine($"{coffee.GetDescription()} = {coffee.GetAmount()} RSD");
        }
    }
}