using System;

namespace DesignPatternExamples.Behavioral.Strategy.DuckExample
{
    public abstract class Duck
    {
        protected IQuackBehavior QuackBehavior;
        protected IFlyBehavior FlyBehavior;
        public virtual void Display() { }
        public virtual void Swim() { }

        public void Fly()
        {
            this.FlyBehavior.Fly();
        }

        public void Quack()
        {
            this.QuackBehavior.Quack();
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new NoFlyBehavior();
            QuackBehavior = new QuackBehavior();
        }
    }

    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            FlyBehavior = new FlyWithWingsBehavior();
            QuackBehavior = new QuackBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("My head is red");
        }
    }

    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new NoFlyBehavior();
            QuackBehavior = new SqueakBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("I am a rubber duck");
        }
    }

}