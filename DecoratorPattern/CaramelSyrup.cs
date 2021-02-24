namespace DecoratorPattern
{
    public sealed class CaramelSyrup: BeverageDecorator
    {
        private readonly Beverage _beverage;

        public CaramelSyrup(Beverage beverage, int count)
        {
            this._beverage = beverage;
            this._count = count > 0 ? count : 1;
        }

        public override string Description => this._beverage.Description + $", Caramel syrup({this._count})";
        public override double Cost()
        {
            return this._beverage.Cost() + 0.50 * this._count;
        }
    }
}