using Design_Decorator.Interfaces;

namespace Design_Decorator.Concrete
{
    class Chocolate : ICoffeeDecorator
    {
        public ICoffee BaseCoffee { get; set; }

        public Chocolate(ICoffee baseCoffee)
        {
            BaseCoffee = baseCoffee;
        }

        public float Cost()
        {
            return BaseCoffee.Cost() + 15;
        }
    }


}
