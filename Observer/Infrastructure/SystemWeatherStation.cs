namespace Observer.Infrastructure
{
    public class SystemWeatherStation : IObservable<Temperature>
    {
        List<IObserver<Temperature>> _observers;

        public SystemWeatherStation()
        {
            _observers = [];
        }

        public IDisposable Subscribe(IObserver<Temperature> observer)
        {
            if (false == _observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        class Unsubscriber : IDisposable
        {
            List<IObserver<Temperature>> _observers;
            IObserver<Temperature> _observer;

            public Unsubscriber(List<IObserver<Temperature>> observers, IObserver<Temperature> observer)
            {
                _observers = observers;
                _observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }

        public void TrackTemperature(Temperature temp)
        {
            foreach (var observer in _observers)
            {
                if (temp is null)
                    observer.OnError(new TemperatureUnknownException());
                else
                    observer.OnNext(temp);
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in _observers.ToArray())
                if (_observers.Contains(observer))
                    observer.OnCompleted();

            _observers.Clear();
        }
    }

    public class TemperatureUnknownException : Exception
    {
        internal TemperatureUnknownException() { }
    }

    public class Temperature
    {
        public int Value { get; protected set; }

        public Temperature(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
