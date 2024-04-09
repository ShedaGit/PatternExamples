namespace AbstractFactory.Infrastructure.Interfaces
{
    public interface IFactory
    {
        public IProductA GetProductA();

        public IProductB GetProductB();
    }
}
