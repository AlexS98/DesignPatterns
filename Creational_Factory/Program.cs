using System;

using Creational_Factory.Interfaces;

namespace Creational_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i++)
            {
                object product = $"Product {i}";
                IDeliveryMethod deliveryMethod = MatchDeliveryMethod.GetDeliveryMethod(product);
                IDeliveryItem deliveryItem = deliveryMethod.GetDeliveryItem(product);
                deliveryItem.StartDelivering();
                Console.WriteLine($"{deliveryItem.Product.ToString()} : {deliveryItem.Status}");
            }
        }
    }
}
