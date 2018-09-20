using System;

namespace DesignPatternExamples.Behavioral.Strategy.DuckExample
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public class FlyWithWingsBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings");
        }
    }

    public class NoFlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No fly");
        }
    }

    public interface IQuackBehavior
    {
        void Quack();
    }

    public class QuackBehavior : IQuackBehavior {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }

    public class SqueakBehavior : IQuackBehavior {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }

    public class MuteQuackBehavor : IQuackBehavior
    {
        public void Quack()
        {
            
        }
    }
}