using DesignPatternExamples.Structural.Decorator;

namespace DesignPatternExamples.Creational.Builder
{
    public interface IBuilder
    {
        void Reset();
        IBuilder PrepareCoffee();
        IBuilder WithMilk();
        IBuilder AddDiscount(decimal percent);
        IBeverage Build();
    }
}