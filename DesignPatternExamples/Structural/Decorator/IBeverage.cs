namespace DesignPatternExamples.Structural.Decorator
{
    public interface IBeverage
    {
        string Name { get; }
        decimal Price { get; }
        decimal GetAmount();
        string GetDescription();
    }

    public abstract class Beverage : IBeverage
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public virtual decimal GetAmount()
        {
            return Price;
        }

        public virtual string GetDescription()
        {
            return Name;
        }
    }
}