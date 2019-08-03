using Creational_Factory.Interfaces;

namespace Creational_Factory.Concrete
{
    public class BoxDelivery : IDeliveryMethod
    {

        public IDeliveryItem GetDeliveryItem(object product)
        {
            return new Box(product);
        }
    }
}
