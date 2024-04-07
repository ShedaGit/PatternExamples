using Strategy.Infrastructure.Interfaces;

namespace Strategy.Infrastructure.Strategies
{
    internal class NoQuackStrategy : IQuackStrategy
    {
        public void Quack() { }
    }
}
