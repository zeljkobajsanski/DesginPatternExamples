namespace DesignPatternExamples.Structural.Bridge.ShapesDemo
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