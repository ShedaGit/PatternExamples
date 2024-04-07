// See https://aka.ms/new-console-template for more information
using Observer.Infrastructure;

var weatherStationManual = new WeatherStation();
var phoneA = new PhoneDisplay("A", weatherStationManual);
var phoneB = new PhoneDisplay("B", weatherStationManual);

weatherStationManual.Add(phoneA);
weatherStationManual.Add(phoneB);

weatherStationManual.SetTemperature(23);
weatherStationManual.Notify();

weatherStationManual.Remove(phoneA);

weatherStationManual.SetTemperature(25);
weatherStationManual.Notify();

