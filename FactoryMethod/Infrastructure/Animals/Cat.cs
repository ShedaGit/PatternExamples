using FactoryMethod.Infrastructure.Interfaces;

namespace FactoryMethod.Infrastructure.Animals
{
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }
}
