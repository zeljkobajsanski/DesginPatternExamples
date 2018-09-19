using System.Runtime.CompilerServices;

namespace DesignPatternExamples.Structural.Bridge.ConfigurationDemo
{
    public interface IStorage
    {
        void Load();
        void Save();

        void SetValue(string key, object value);

        object GetValue(string key);
    }

    public class DbStorage : IStorage {
        public void Load()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void SetValue(string key, object value)
        {
            throw new System.NotImplementedException();
        }

        public object GetValue(string key)
        {
            throw new System.NotImplementedException();
        }
    }

    public class JsonFileStorage : IStorage
    {
        public void Load()
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void SetValue(string key, object value)
        {
            throw new System.NotImplementedException();
        }

        public object GetValue(string key)
        {
            throw new System.NotImplementedException();
        }
    }
}