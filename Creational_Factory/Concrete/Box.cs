using Creational_Factory.Interfaces;

namespace Creational_Factory.Concrete
{
    public class Box : IDeliveryItem
    {
        public object Product { get; set; }
        public string Status { get; set; }

        public Box(object product)
        {
            Product = product;
        }

        public bool StartDelivering()
        {
            Status = "Box delivering started";
            return true;
        }

        public void UpdateStatus(string status)
        {
            Status = status;
        }
    }
}
