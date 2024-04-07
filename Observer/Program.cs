// See https://aka.ms/new-console-template for more information
using Observer.Infrastructure;

//Example of usage for Christopher Okhravi case
var weatherStationManual = new SimpleWeatherStation();
var phoneA = new SimplePhoneDisplay("A", weatherStationManual);
var phoneB = new SimplePhoneDisplay("B", weatherStationManual);

weatherStationManual.Add(phoneA);
weatherStationManual.Add(phoneB);

weatherStationManual.SetTemperature(new Temperature(23));
weatherStationManual.Notify();

weatherStationManual.Remove(phoneA);

weatherStationManual.SetTemperature(new Temperature(25));
weatherStationManual.Notify();

//Example of usage for System Implementation case. See https://learn.microsoft.com/en-us/dotnet/api/system.iobservable-1?view=net-8.0
var provider = new SystemWeatherStation();
var reporter1 = new SystemPhoneDisplay("C");
reporter1.Subscribe(provider);
var reporter2 = new SystemPhoneDisplay("D");
reporter2.Subscribe(provider);

provider.TrackTemperature(new Temperature(23));
reporter1.Unsubscribe();
provider.TrackTemperature(new Temperature(25));
provider.TrackTemperature(null!);
provider.EndTransmission();
