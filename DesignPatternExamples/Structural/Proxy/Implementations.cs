using System;

namespace DesignPatternExamples.Structural.Proxy
{
    public class RemoteServiceClient : IRemoteService
    {
        public string GetData()
        {
            return "Hello World";
        }
    }


    /// <summary>
    /// All proxy variants into one class: Remote Proxy, Protection Proxy, Virtual (caching) Proxy
    /// </summary>
    public class RemoteServiceProxy : IRemoteService
    {
        private RemoteServiceClient _client;
        public string GetData()
        {
            if (_client == null)
            {
                _client = new RemoteServiceClient();
            }

            if (!HasPermissionsForAccess())
            {
                throw new UnauthorizedAccessException();
            }

            LogAccess();
            return _client.GetData();
        }

        private void LogAccess()
        {
            Console.WriteLine("User accessed resource");
        }

        private bool HasPermissionsForAccess()
        {
            return true;
        }
    }
}