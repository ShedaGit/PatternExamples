namespace Command.Infrastructure
{
    public class LightOnCommand : ICommand
    {
        Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }

        public void Unexecute()
        {
            _light.Off();
        }
    }
}
