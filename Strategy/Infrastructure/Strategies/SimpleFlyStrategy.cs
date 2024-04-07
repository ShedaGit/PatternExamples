using Strategy.Infrastructure.Interfaces;

namespace Strategy.Infrastructure.Strategies
{
    internal class SimpleFlyStrategy : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("Flap");
        }
    }
}
