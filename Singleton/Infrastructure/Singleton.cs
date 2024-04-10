namespace Singleton.Infrastructure
{
    public class Singleton
    {
        static Singleton _instance = null!;

        Singleton() { }

        public static Singleton GetInstance() => _instance ??= new Singleton();
    }
}
