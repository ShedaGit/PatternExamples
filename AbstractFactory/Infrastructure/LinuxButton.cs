using AbstractFactory.Infrastructure.Interfaces;

namespace AbstractFactory.Infrastructure
{
    public class LinuxButton : IProductB
    {
        public string Name => "Linux Button";
    }
}
