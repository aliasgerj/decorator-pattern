namespace DecoratorPattern
{
    public sealed class Coffee: Beverage
    {
        public override string Description => "Coffee";

        public override double Cost()
        {
            return 3.00;
        }
    }
}