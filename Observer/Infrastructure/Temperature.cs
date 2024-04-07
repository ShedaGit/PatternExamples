namespace Observer.Infrastructure
{
    public class Temperature
    {
        public int Value { get; protected set; }

        public Temperature(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
