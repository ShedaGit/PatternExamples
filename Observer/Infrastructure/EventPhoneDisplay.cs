namespace Observer.Infrastructure
{
    public class EventPhoneDisplay
    {
        readonly string _name;

        public EventPhoneDisplay(string phoneName)
        {
            _name = phoneName;
        }

        public void Update(object? sender, EventArgs e)
        {
            if (sender is EventWeatherStation station)
                Console.WriteLine($"Phone {_name}: current temperature is {station.Temperature}°C.");
            else
                throw new TemperatureUnknownException();
        }
    }
}
