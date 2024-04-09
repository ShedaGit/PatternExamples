namespace Decorator.Infrastructure.Addons
{
    public class Caramel : AddonDecorator
    {
        readonly Beverage _beverage;

        public Caramel(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override int Cost()
        {
            return _beverage.Cost() + 2;
        }
    }
}
