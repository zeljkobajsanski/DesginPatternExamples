using System;

namespace DesignPatternExamples.Behavioral.Command.RemoteControl
{
    public class TvSet
    {
        public void TurnOn()
        {
            Console.WriteLine("TV set is turned on");
        }

        public void TurnOff()
        {
            Console.WriteLine("TV set is turned off");
        }
    }
}