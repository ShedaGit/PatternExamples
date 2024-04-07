using Strategy.Infrastructure.Interfaces;

namespace Strategy.Strategies
{
    internal class SimpleQuackStrategy : IQuackStrategy
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
