using Creational_Factory.Interfaces;

namespace Creational_Factory.Concrete
{
    public class Container : IDeliveryItem
    {
        public object Product { get; set; }
        public string Status { get; set; }

        public Container(object product)
        {
            Product = product;
        }

        public bool StartDelivering()
        {
            Status = "Container delivering started";
            return true;
        }

        public void UpdateStatus(string status)
        {
            Status = status;
        }
    }
}
