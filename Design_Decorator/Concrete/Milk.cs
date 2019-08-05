using Design_Decorator.Interfaces;

namespace Design_Decorator.Concrete
{
    public class Milk : ICoffeeDecorator
    {
        public ICoffee BaseCoffee { get; set; }

        public Milk(ICoffee baseCoffee)
        {
            BaseCoffee = baseCoffee;
        }

        public float Cost()
        {
            return BaseCoffee.Cost() + 5;
        }
    }
}
