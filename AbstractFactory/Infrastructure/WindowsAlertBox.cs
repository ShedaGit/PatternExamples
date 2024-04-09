using AbstractFactory.Infrastructure.Interfaces;

namespace AbstractFactory.Infrastructure
{
    public class WindowsAlertBox : IProductA
    {
        public string Name => "Windows Alert Box";
    }
}
