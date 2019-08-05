using Design_Decorator.Interfaces;

namespace Design_Decorator.Concrete
{
    public class Espresso : ICoffee
    { 
        public float Cost()
        {
            return 8f;
        }
    }
}
