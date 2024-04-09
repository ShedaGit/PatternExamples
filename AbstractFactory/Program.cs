// See https://aka.ms/new-console-template for more information

using AbstractFactory.Infrastructure;

var windowsFactory = new AlertBoxFactory(new WindowsAlertBox(), new WindowsButton());
var linuxFactory = new AlertBoxFactory(new LinuxAlertBox(), new LinuxButton());

var windowsAlert = windowsFactory.GetProductA();
var windowsButton = windowsFactory.GetProductB();

Console.WriteLine(windowsAlert.Name + " - " + windowsButton.Name);

var linuxAlert = linuxFactory.GetProductA();
var linuxButton = linuxFactory.GetProductB();

Console.WriteLine(linuxAlert.Name + " - " + linuxButton.Name);

