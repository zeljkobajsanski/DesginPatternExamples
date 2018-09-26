using DesignPatternExamples.Structural.Decorator;

namespace DesignPatternExamples.Creational.Builder
{
    public class CoffeeBuilder : IBuilder
    {
        private IBeverage _beverage;

        public void Reset()
        {
            _beverage = null;
        }

        public IBuilder PrepareCoffee()
        {
            _beverage = new Coffee();
            return this;
        }

        public IBuilder WithMilk()
        {
            _beverage = new MilkDecorator(_beverage);
            return this;
        }

        public IBuilder AddDiscount(decimal percent)
        {
            _beverage = new DiscountedBeverageDecorator(_beverage){Percent = percent};
            return this;
        }

        public IBeverage Build()
        {
            return _beverage;
        }
    }
}