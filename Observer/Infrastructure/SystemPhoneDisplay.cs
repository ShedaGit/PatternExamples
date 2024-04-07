namespace Observer.Infrastructure
{
    public class SystemPhoneDisplay : IObserver<Temperature>
    {
        readonly string _name;
        IDisposable _unsubscriber = null!;

        public SystemPhoneDisplay(string name)
        {
            _name = name;
        }

        public virtual void Subscribe(IObservable<Temperature> provider)
        {
            if (provider != null)
                _unsubscriber = provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            Console.WriteLine($"Phone {_name} completed.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"Error: {error.Message}");
        }

        public void OnNext(Temperature value)
        {
            Console.WriteLine($"Phone {_name}: current temperature is {value}°C.");
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}
