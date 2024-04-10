namespace Command.Infrastructure
{
    public class Invoker
    {
        ICommand _on;
        ICommand _off;

        public Invoker(ICommand on, ICommand off)
        {
            _on = on;
            _off = off;
        }

        public void ClickOn() => _on.Execute();

        public void ClickOff() => _off.Execute();
    }
}
