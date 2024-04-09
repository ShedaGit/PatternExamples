using FactoryMethod.Infrastructure.Animals;
using FactoryMethod.Infrastructure.Interfaces;

namespace FactoryMethod.Infrastructure
{
    public class BalancedFactory : IAnimalFactory
    {
        readonly static Random _random = new Random();
        readonly Animal[] _baseAnimals;
        List<Animal> _animalsToChoose;

        public BalancedFactory()
        {
            _baseAnimals =
            [
                new Cat(),
                new Dog(),
                new Fox()
            ];

            _animalsToChoose = [.. _baseAnimals];
        }

        public Animal CreateAnimal()
        {
            Animal animal;
            if (_animalsToChoose.Count > 0)
            {
                animal = _animalsToChoose[_random.Next(0, _animalsToChoose.Count)];

                _animalsToChoose.Remove(animal);

                return animal switch
                {
                    Cat => new Cat(),
                    Dog => new Dog(),
                    Fox => new Fox(),
                    _ => throw new InvalidOperationException()
                };
            }
            else
            {
                _animalsToChoose = [.. _baseAnimals];
                return CreateAnimal();
            }
        }
    }
}
