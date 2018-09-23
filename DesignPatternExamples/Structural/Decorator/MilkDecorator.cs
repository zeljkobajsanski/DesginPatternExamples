namespace DesignPatternExamples.Structural.Decorator
{
    public class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(IBeverage wrappee) : base(wrappee)
        {
            Name = "Milk";
            Price = 50;
        }
    }
}