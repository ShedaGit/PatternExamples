// See https://aka.ms/new-console-template for more information
using Command.Infrastructure;

var light = new Light();

var lightOnCommand = new LightOnCommand(light);
var lightOffCommand = new LightOffCommand(light);

var casualInvoker = new Invoker(lightOnCommand, lightOffCommand);
var invertedInvoker = new Invoker(lightOffCommand, lightOnCommand);

casualInvoker.ClickOn();
invertedInvoker.ClickOn();
