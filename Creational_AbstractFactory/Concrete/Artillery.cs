using System;

using Creational_AbstractFactory.Interfaces;

namespace Creational_AbstractFactory.Concrete
{
    public class ArtilleryFactory : IDivisionFactory
    {

        public ILightDivision CreateLightDivision()
        {
            return new AntiTankArtillery();
        }

        public IRegularDivision CreateMediumDivision()
        {
            return new MobileArtillery();
        }
        public IEliteDivision CreateHeavyDivision()
        {
            return new RocketArtillery();
        }
    }

    public class AntiTankArtillery : ILightDivision
    {
        public string CountryCode { get; set; }
        public int Number { get; set; }
        public long Manpower { get; set; }
        public string Status { get; set; }

        public void Attack(IDivision enemy)
        {
            Console.WriteLine(typeof(AntiTankArtillery) + ": attack");
        }

        public void Ambush()
        {
            Status = "AntiTankArtillery: Waiting for tanks...";
        }
    }

    public class MobileArtillery : IRegularDivision
    {
        public string CountryCode { get; set; }
        public int Number { get; set; }
        public long Manpower { get; set; }
        public string Status { get; set; }

        public void Attack(IDivision enemy)
        {
            Console.WriteLine(typeof(MobileArtillery) + ": attack");
        }

        public void HardDefense()
        {
            Status = "MobileArtillery: Artillery entrenched!";
        }
    }

    public class RocketArtillery : IEliteDivision
    {
        public string CountryCode { get; set; }
        public int Number { get; set; }
        public long Manpower { get; set; }
        public string Status { get; set; }

        public void Attack(IDivision enemy)
        {
            Console.WriteLine(typeof(RocketArtillery) + ": attack");
        }

        public void SpecialAttack()
        {
            Status = "RocketArtillery: High-explosive fragmentation rockets loaded";
        }
    }
}
