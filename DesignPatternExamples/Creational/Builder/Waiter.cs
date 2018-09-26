using DesignPatternExamples.Structural.Decorator;

namespace DesignPatternExamples.Creational.Builder
{
    public class Waiter
    {
        private readonly IBuilder _builder;

        public Waiter(IBuilder builder)
        {
            _builder = builder;
        }

        public IBeverage GetEspressoWithMilk()
        {
            return _builder.PrepareCoffee().WithMilk().Build();
        }

        public IBeverage GetCoffeeWithDiscount()
        {
            return _builder.PrepareCoffee().AddDiscount(15).Build();
        }
    }
}