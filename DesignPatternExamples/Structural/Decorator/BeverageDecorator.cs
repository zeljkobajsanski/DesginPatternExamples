namespace DesignPatternExamples.Structural.Decorator
{
    public class BeverageDecorator : Beverage
    {
        protected IBeverage Wrappee;

        public BeverageDecorator(IBeverage wrappee)
        {
            Wrappee = wrappee;
        }

        public override string GetDescription()
        {
            return Wrappee.GetDescription() + " with " + Name;
        }

        public override decimal GetAmount()
        {
            return Wrappee.GetAmount() + Price;
        }
    }
}