using System.Runtime.InteropServices;

namespace DesignPatternExamples.Structural.Bridge
{
    public class Client
    {
        public void RunDemo()
        {
            Shape circle = new Circle(new BlackColor());
            circle.Draw();

            circle = new Triangle(new WhiteColor());
            circle.Draw();
        }
    }
}