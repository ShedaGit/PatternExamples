namespace Command.Infrastructure
{
    public interface ICommand
    {
        void Execute();

        void Unexecute();
    }
}
