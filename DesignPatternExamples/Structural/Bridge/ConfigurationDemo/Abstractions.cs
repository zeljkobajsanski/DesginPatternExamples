namespace DesignPatternExamples.Structural.Bridge.ConfigurationDemo
{
    public class Configuration
    {
        protected IStorage Storage;

        public Configuration(IStorage storage)
        {
            Storage = storage;
        }

        public void LoadConfiguration() { Storage.Load(); }
        public void SaveConfiguration() { Storage.Save(); }
        public void SetValue(string key, object value) { Storage.SetValue(key, value); }
        public object GetValue(string key) { return Storage.GetValue(key); }
    }
}