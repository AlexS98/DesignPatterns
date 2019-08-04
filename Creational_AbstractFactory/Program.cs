using System;
using System.Collections.Generic;

using Creational_AbstractFactory.Concrete;
using Creational_AbstractFactory.Interfaces;

namespace Creational_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDivisionFactory> divisionFactories = new List<IDivisionFactory>
            {
                new ArtilleryFactory(),
                new InfantryFactory()
            };

            foreach (var item in divisionFactories)
            {
                ILightDivision lightDivision = item.CreateLightDivision();
                lightDivision.Ambush();
                Console.WriteLine(lightDivision.Status);

                IRegularDivision regularDivision = item.CreateMediumDivision();
                regularDivision.HardDefense();
                Console.WriteLine(regularDivision.Status);

                IEliteDivision eliteDivision = item.CreateHeavyDivision();
                eliteDivision.SpecialAttack();
                Console.WriteLine(eliteDivision.Status);
            }
        }
    }
}
