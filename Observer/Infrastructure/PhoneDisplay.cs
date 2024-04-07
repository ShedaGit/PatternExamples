using Observer.Infrastructure.Interfaces;

namespace Observer.Infrastructure
{
    public class PhoneDisplay : IObserver
    {
        readonly string _name;
        readonly WeatherStation _station;

        public PhoneDisplay(string phoneName, WeatherStation station)
        {
            _name = phoneName;
            _station = station;
        }

        public void Update()
        {
            DisplayCurrentTemperature(_station.GetTemperature());
        }

        void DisplayCurrentTemperature(int temperature)
        {
            Console.WriteLine($"Phone {_name}: current temperature is {temperature}°C.");
        }
    }
}
