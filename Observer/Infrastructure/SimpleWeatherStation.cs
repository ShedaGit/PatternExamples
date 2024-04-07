using Observer.Infrastructure.Interfaces;

namespace Observer.Infrastructure
{
    public class SimpleWeatherStation : IObservable
    {
        readonly List<IObserver> _observers;
        Temperature _temperature = null!;

        public SimpleWeatherStation()
        {
            _observers = [];
        }

        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
                observer.Update();
        }

        public Temperature GetTemperature() => _temperature;

        public void SetTemperature(Temperature value) => _temperature = value;
    }
}
