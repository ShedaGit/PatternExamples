// See https://aka.ms/new-console-template for more information
using Decorator.Infrastructure;
using Decorator.Infrastructure.Addons;
using Decorator.Infrastructure.Drinks;

var espresso = MakeEspresso();

Console.WriteLine($"Base cost of {nameof(Espresso)} is {espresso.Cost()}$.");

var espressoWithCaramel = AddCaramel(espresso);
var espressoWithDoubleCaramel = AddCaramel(espressoWithCaramel);

Console.WriteLine($"Cost of {nameof(Espresso)} with x2 caramel addons is {espressoWithDoubleCaramel.Cost()}$.");



Beverage MakeEspresso()
{
    return new Espresso();
}

Beverage AddCaramel(Beverage beverage)
{
    return new Caramel(beverage);
}