namespace DesignPatternExamples.Behavioral.Command.RemoteControl
{
    public class Client
    {
        public void Run()
        {
            var tv = new TvSet();
            var turnOnCommand = new TurnOnTvCommand(tv);
            var turnOffCommand = new TurnOffTvCommand(tv);

            var remoteControl = new RemoteControl();
            remoteControl.SetTurnOnCommand(turnOnCommand);
            remoteControl.SetTurnOffCommand(turnOffCommand);

            remoteControl.TurnOnTv();
            remoteControl.TurnOffTv();

        }
    }
}