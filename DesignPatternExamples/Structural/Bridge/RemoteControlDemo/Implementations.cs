namespace DesignPatternExamples.Structural.Bridge.RemoteControlDemo
{
    public interface IDevice
    {
        bool IsTurnedOn { get; }
        void TurnOn();
        void TurnOff();
        int GetCurrentChannel();
        int SetCurrentChannel(int channel);
        int GetVolume();
        void SetVolume(int volume);
    }

    public class TV : IDevice {
        public bool IsTurnedOn { get; }

        public void TurnOn()
        {
            throw new System.NotImplementedException();
        }

        public void TurnOff()
        {
            throw new System.NotImplementedException();
        }

        public int GetCurrentChannel()
        {
            throw new System.NotImplementedException();
        }

        public int SetCurrentChannel(int channel)
        {
            throw new System.NotImplementedException();
        }

        public int GetVolume()
        {
            throw new System.NotImplementedException();
        }

        public void SetVolume(int volume)
        {
            throw new System.NotImplementedException();
        }
    }
}