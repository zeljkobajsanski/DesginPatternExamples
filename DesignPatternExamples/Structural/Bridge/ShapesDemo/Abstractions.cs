using System;

namespace DesignPatternExamples.Structural.Bridge
{
    public abstract class Shape
    {
        protected IColor Color;

        protected Shape(IColor color)
        {
            Color = color;
        }

        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public Circle(IColor color) : base(color)
        {
        }
        public override void Draw()
        {
            Console.WriteLine($"Creating {Color.Paint()} circle");
        }
        
    }

    public class Triangle : Shape
    {
        public Triangle(IColor color) : base(color)
        {
        }
        public override void Draw()
        {
            Console.WriteLine($"Creating {Color.Paint()} triangle");
        }
    }
}