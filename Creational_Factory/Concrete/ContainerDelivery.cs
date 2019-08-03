using Creational_Factory.Interfaces;

namespace Creational_Factory.Concrete
{
    public class ContainerDelivery : IDeliveryMethod
    {

        public IDeliveryItem GetDeliveryItem(object product)
        {
            return new Container(product);
        }
    }
}
