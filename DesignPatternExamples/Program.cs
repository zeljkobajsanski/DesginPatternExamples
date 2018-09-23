using System;
using DesignPatternExamples.Structural.Bridge;
using DesignPatternExamples.Structural.Decorator;
using Client = DesignPatternExamples.Creational.FactoryMethod.LogisticsDemo.Client;

namespace DesignPatternExamples
{
    public class Program
    {
        public static void Main()
        {
            new DecoratorDemo().Run();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}