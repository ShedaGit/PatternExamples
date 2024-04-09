using AbstractFactory.Infrastructure.Interfaces;

namespace AbstractFactory.Infrastructure
{
    public class LinuxAlertBox : IProductA
    {
        public string Name => "Linux Alert Box";
    }
}
