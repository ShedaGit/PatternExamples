// See https://aka.ms/new-console-template for more information
using FactoryMethod.Infrastructure;
using FactoryMethod.Infrastructure.Interfaces;

var randomFactory = new RandomFactory();
var balancedFactory = new BalancedFactory();

var animalCount = 6;

Console.WriteLine($"Getting {animalCount} animals from {nameof(RandomFactory)}.");
GetAnimals(randomFactory, animalCount);

Console.WriteLine(Environment.NewLine);

Console.WriteLine($"Getting {animalCount} animals from {nameof(BalancedFactory)}.");
GetAnimals(balancedFactory, animalCount);

static void GetAnimals(IAnimalFactory randomFactory, int animalCount)
{
    for (int i = 0; i < animalCount; i++)
        randomFactory.CreateAnimal().Speak();
}
