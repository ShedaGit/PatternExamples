using Strategy.Infrastructure.Interfaces;

namespace Strategy.Infrastructure.Strategies
{
    internal class NoFlyStrategy : IFlyStrategy
    {
        public void Fly() { }
    }
}
