namespace DesignPatternExamples.Behavioral.Command.RemoteControl
{
    public interface ICommand
    {
        void Execute();
    }

    public class TurnOnTvCommand : ICommand
    {
        private readonly TvSet _receiver;

        public TurnOnTvCommand(TvSet receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.TurnOn();
        }
    }

    public class TurnOffTvCommand : ICommand
    {
        private readonly TvSet _receiver;

        public TurnOffTvCommand(TvSet receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.TurnOff();
        }
    }
}