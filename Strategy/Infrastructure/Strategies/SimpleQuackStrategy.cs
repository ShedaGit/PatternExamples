using Strategy.Infrastructure.Interfaces;

namespace Strategy.Infrastructure.Strategies
{
    internal class SimpleQuackStrategy : IQuackStrategy
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
