namespace DesignPatternExamples.Behavioral.Observer
{
    public interface IObserver
    {
        void Update(string value, IObservable subject);
    }
}