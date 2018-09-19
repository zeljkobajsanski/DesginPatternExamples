namespace DesignPatternExamples.Structural.Bridge.RemoteControlDemo
{
    public class Client
    {
        public void RunDemo()
        {
            var remote = new Remote(new TV());
            remote.TurnOn();
            remote.ChangeChannel(111);
            remote.TurnOff();
        }
    }
}