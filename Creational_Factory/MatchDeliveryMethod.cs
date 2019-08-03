using System;
using System.Collections.Generic;
using System.Text;
using Creational_Factory.Concrete;
using Creational_Factory.Interfaces;

namespace Creational_Factory
{
    public class MatchDeliveryMethod
    {
        public static IDeliveryMethod GetDeliveryMethod(object product)
        {
            if(int.TryParse(product.ToString().Split(' ')[1], out int number))
            {
                if (number % 2 == 0)
                    return new ContainerDelivery();
                else
                    return new BoxDelivery();
            }
            throw new Exception("Wrong product");
        }
    }
}
