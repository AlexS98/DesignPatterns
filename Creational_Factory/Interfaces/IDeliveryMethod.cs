namespace Creational_Factory.Interfaces
{
    public interface IDeliveryMethod
    {
        IDeliveryItem GetDeliveryItem(object product);
    }
}
