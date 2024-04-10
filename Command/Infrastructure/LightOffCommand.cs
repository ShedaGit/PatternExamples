namespace Command.Infrastructure
{
    public class LightOffCommand : ICommand
    {
        Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }

        public void Unexecute()
        {
            _light.On();
        }
    }
}
