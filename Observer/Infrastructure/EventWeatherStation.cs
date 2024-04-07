using Observer.Infrastructure.Interfaces;

namespace Observer.Infrastructure
{
    public class EventWeatherStation : IObservableEvent
    {
        public event EventHandler? StateChanged;

        private Temperature _temperature = null!;

        public Temperature Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                OnStateChanged();
            }
        }

        protected virtual void OnStateChanged()
        {
            StateChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
