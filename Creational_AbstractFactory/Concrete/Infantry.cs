using System;

using Creational_AbstractFactory.Interfaces;

namespace Creational_AbstractFactory.Concrete
{
    public class InfantryFactory : IDivisionFactory
    {
        public ILightDivision CreateLightDivision()
        {
            return new LightInfantry();
        }

        public IRegularDivision CreateMediumDivision()
        {
            return new RegularInfantry();
        }

        public IEliteDivision CreateHeavyDivision()
        {
            return new SpecialForces();
        }
    }

    public class LightInfantry : ILightDivision
    {
        public string CountryCode { get; set; }
        public int Number { get; set; }
        public long Manpower { get; set; }
        public string Status { get; set; }

        public void Attack(IDivision enemy)
        {
            Console.WriteLine(typeof(LightInfantry) + ": attack");
        }

        public void Ambush()
        {
            Status = "LightInfantry: Partisan tactics...";
        }
    }

    public class RegularInfantry : IRegularDivision
    {
        public string CountryCode { get; set; }
        public int Number { get; set; }
        public long Manpower { get; set; }
        public string Status { get; set; }

        public void Attack(IDivision enemy)
        {
            Console.WriteLine(typeof(RegularInfantry) + ": attack");
        }

        public void HardDefense()
        {
            Status = "RegularInfantry: No way out!";
        }
    }

    public class SpecialForces : IEliteDivision
    {
        public string CountryCode { get; set; }
        public int Number { get; set; }
        public long Manpower { get; set; }
        public string Status { get; set; }

        public void Attack(IDivision enemy)
        {
            Console.WriteLine(typeof(SpecialForces) + ": attack");
        }

        public void SpecialAttack()
        {
            Status = "SpecialForces: No fear!";
        }
    }
}
