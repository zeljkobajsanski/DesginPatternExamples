using System;
using DesignPatternExamples.Structural.Bridge;
using Client = DesignPatternExamples.Creational.FactoryMethod.LogisticsDemo.Client;

namespace DesignPatternExamples
{
    public class Program
    {
        public static void Main()
        {
            new Client().RunDemo();
            Console.ReadKey();
        }
    }
}