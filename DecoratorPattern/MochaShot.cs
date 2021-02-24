namespace DecoratorPattern
{
    public sealed class MochaShot: BeverageDecorator
    {
        private readonly Beverage _beverage;

        public MochaShot(Beverage beverage, int count)
        {
            this._beverage = beverage;
            this._count = count > 0 ? count : 1;
        }

        public override string Description => this._beverage.Description + $", Mocha({this._count})";
        public override double Cost()
        {
            return this._beverage.Cost() + 3 * this._count;
        }
    }
}