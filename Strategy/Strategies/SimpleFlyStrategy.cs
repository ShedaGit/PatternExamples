using Strategy.Infrastructure.Interfaces;

namespace Strategy.Strategies
{
    internal class SimpleFlyStrategy : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("Flap");
        }
    }
}
