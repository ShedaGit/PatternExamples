using Strategy.Infrastructure.Interfaces;

namespace Strategy.Infrastructure
{
    internal class Duck
    {
        IDisplayStrategy _displayStrategy;
        IQuackStrategy _quackStrategy;
        IFlyStrategy _flyStrategy;

        protected Duck(IDisplayStrategy displayStrategy, IQuackStrategy quackStrategy, IFlyStrategy flyStrategy)
        {
            _displayStrategy = displayStrategy;
            _quackStrategy = quackStrategy;
            _flyStrategy = flyStrategy;
        }

        public void Display()
        {
            _displayStrategy.Display();
        }

        public void Quack()
        {
            _quackStrategy.Quack();
        }

        public void Fly()
        {
            _flyStrategy.Fly();
        }
    }
}
