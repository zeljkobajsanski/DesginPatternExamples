namespace DesignPatternExamples.Structural.Bridge.RemoteControlDemo
{
    public class Remote
    {
        protected IDevice Device;

        public Remote(IDevice device)
        {
            Device = device;
        }

        public void TurnOn()
        {
            if (!Device.IsTurnedOn)
            {
                Device.TurnOn();
            }
        }

        public void TurnOff()
        {
            if (Device.IsTurnedOn)
            {
                Device.TurnOff();
            }
        }

        public void ChangeChannel(int channel)
        {
            Device.SetCurrentChannel(channel);
        }
    }

    public class AdvancedRemote : Remote
    {
        public AdvancedRemote(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            Device.SetVolume(0);
        }
    }
}