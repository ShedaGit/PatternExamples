using FactoryMethod.Infrastructure.Animals;
using FactoryMethod.Infrastructure.Interfaces;

namespace FactoryMethod.Infrastructure
{
    public class RandomFactory : IAnimalFactory
    {
        readonly static Random _random = new Random();
        readonly Animal[] _animals;

        public RandomFactory()
        {
            _animals =
            [
                new Cat(),
                new Dog(),
                new Fox()
            ];
        }

        public Animal CreateAnimal()
        {
            var animal = _animals[_random.Next(0, _animals.Length)];

            return animal switch
            {
                Cat => new Cat(),
                Dog => new Dog(),
                Fox => new Fox(),
                _ => throw new InvalidOperationException()
            };
        }
    }
}
