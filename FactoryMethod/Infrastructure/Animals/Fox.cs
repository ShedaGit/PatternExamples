using FactoryMethod.Infrastructure.Interfaces;

namespace FactoryMethod.Infrastructure.Animals
{
    public class Fox : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Ring-ding-ding-ding-dingeringeding");
        }
    }
}
