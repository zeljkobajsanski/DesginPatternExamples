namespace DesignPatternExamples.Structural.Proxy
{
    public class ProxyDemo
    {
        public void Run()
        {
            IRemoteService remoteService = new RemoteServiceProxy();
            remoteService.GetData();
        }
    }
}