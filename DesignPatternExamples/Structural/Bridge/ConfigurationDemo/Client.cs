namespace DesignPatternExamples.Structural.Bridge.ConfigurationDemo
{
    public class Client
    {
        public void RunDemo()
        {
            var cfg = new Configuration(new DbStorage());
            cfg.LoadConfiguration();
            cfg.SetValue("ConnectionString", "Foo");
            cfg.GetValue("ConnectionString");
            cfg.SaveConfiguration();
        }
    }
}