using Design_Decorator.Interfaces;

namespace Design_Decorator.Concrete
{
    public class Americano : ICoffee
    {
        public float Cost()
        {
            return 8.5f;
        }
    }
}
