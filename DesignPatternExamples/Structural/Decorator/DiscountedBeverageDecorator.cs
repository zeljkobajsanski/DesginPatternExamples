namespace DesignPatternExamples.Structural.Decorator
{
    public class DiscountedBeverageDecorator : BeverageDecorator
    {
        public decimal Percent { get; set; }
        public DiscountedBeverageDecorator(IBeverage wrappee) : base(wrappee)
        {
        }

        public override decimal GetAmount()
        {
            return Wrappee.GetAmount() * (1 - Percent / 100);
        }

        public override string GetDescription()
        {
            return Wrappee.GetDescription() + $" - {Percent}%";
        }
    }
}