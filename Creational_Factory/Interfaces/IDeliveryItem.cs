namespace Creational_Factory.Interfaces
{
    public interface IDeliveryItem
    {
        object Product { get; set; }
        string Status { get; set; }
        bool StartDelivering();
        void UpdateStatus(string status);
    }
}
