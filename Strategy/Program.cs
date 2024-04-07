// See https://aka.ms/new-console-template for more information
using Strategy.Infrastructure;
using Strategy.Infrastructure.Strategies;

var cityDuckDisplayStrategy = new SimpleDisplayStrategy("City Duck");
var simpleQuackStrategy = new SimpleQuackStrategy();
var simpleFlyStrategy = new SimpleFlyStrategy();

var rubberDuckDisplayStrategy = new SimpleDisplayStrategy("Rubber Duck");
var noQuackStrategy = new NoQuackStrategy();
var noFlyStrategy = new NoFlyStrategy();

var cityDuck = new Duck(cityDuckDisplayStrategy, simpleQuackStrategy, simpleFlyStrategy);
var rubberDuck = new Duck(rubberDuckDisplayStrategy, noQuackStrategy, noFlyStrategy);

DisplayDuck(cityDuck);
Console.WriteLine(Environment.NewLine);
DisplayDuck(rubberDuck);

void DisplayDuck(Duck duck) 
{
    duck.Display();
    duck.Quack();
    duck.Fly();
}
