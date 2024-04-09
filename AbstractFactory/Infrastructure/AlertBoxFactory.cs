using AbstractFactory.Infrastructure.Interfaces;

namespace AbstractFactory.Infrastructure
{
    public class AlertBoxFactory : IFactory
    {
        //It can be the same concretion, but constructed differently
        readonly IProductA _alert;
        readonly IProductB _button;

        public AlertBoxFactory(IProductA alert, IProductB button)
        {
            _alert = alert;
            _button = button;
        }

        public IProductA GetProductA()
        {
            return _alert;
        }

        public IProductB GetProductB()
        {
            return _button;
        }
    }
}
