using System;
using DesignPatternExamples.Creational.Builder;
using DesignPatternExamples.Structural.Bridge;
using DesignPatternExamples.Structural.Decorator;
using Client = DesignPatternExamples.Creational.FactoryMethod.LogisticsDemo.Client;

namespace DesignPatternExamples
{
    public class Program
    {
        public static void Main()
        {
            //new DecoratorDemo().Run();
            //new BuilderDemo().Run();
            new Behavioral.Command.RemoteControl.Client().Run();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}