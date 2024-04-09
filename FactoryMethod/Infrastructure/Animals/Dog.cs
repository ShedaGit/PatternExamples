using FactoryMethod.Infrastructure.Interfaces;

namespace FactoryMethod.Infrastructure.Animals
{
    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
    }
}
