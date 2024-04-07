using Observer.Infrastructure.Interfaces;

namespace Observer.Infrastructure
{
    public class SimplePhoneDisplay : IObserver
    {
        readonly string _name;
        readonly SimpleWeatherStation _station;

        public SimplePhoneDisplay(string phoneName, SimpleWeatherStation station)
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
