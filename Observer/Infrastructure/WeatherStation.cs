using Observer.Infrastructure.Interfaces;

namespace Observer.Infrastructure
{
    public class WeatherStation : IObservable
    {
        readonly List<IObserver> _observers;

        int _temperature;

        public WeatherStation()
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

        public int GetTemperature() => _temperature;

        public void SetTemperature(int value) => _temperature = value;
    }
}
