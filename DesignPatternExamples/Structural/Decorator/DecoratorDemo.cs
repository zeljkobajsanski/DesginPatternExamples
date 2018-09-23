using System;

namespace DesignPatternExamples.Structural.Decorator
{
    public class DecoratorDemo
    {
        public void Run()
        {
            IBeverage espressoWithMilk = new MilkDecorator(new Coffee());
            var amount = espressoWithMilk.GetAmount();
            var description = espressoWithMilk.GetDescription();

            Console.WriteLine($"Your order {description}");
            Console.WriteLine($"Total amount {amount} RSD");

            espressoWithMilk = new DiscountedBeverageDecorator(espressoWithMilk){Percent = 10};
            Console.WriteLine($"Your order {espressoWithMilk.GetDescription()}");
            Console.WriteLine($"Total amount {espressoWithMilk.GetAmount()} RSD");

        }
    }
}