namespace Observer.Infrastructure.Interfaces
{
    public interface IObservableEvent
    {
        event EventHandler? StateChanged;
    }
}
