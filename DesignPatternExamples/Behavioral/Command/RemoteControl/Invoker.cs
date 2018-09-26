namespace DesignPatternExamples.Behavioral.Command.RemoteControl
{
    public class RemoteControl
    {
        private ICommand _turnOnCommand;
        private ICommand _turnOffCommand;

        public void SetTurnOnCommand(ICommand command)
        {
            this._turnOnCommand = command;
        }

        public void SetTurnOffCommand(ICommand command)
        {
            this._turnOffCommand = command;
        }

        public void TurnOnTv()
        {
            this._turnOnCommand.Execute();
        }

        public void TurnOffTv()
        {
            this._turnOffCommand.Execute();
        }
    }
}