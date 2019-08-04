namespace Creational_AbstractFactory.Interfaces
{
    public interface IDivision
    {
        string CountryCode { get; set; }
        int Number { get; set; }
        long Manpower { get; set; }
        string Status { get; set; }
        void Attack(IDivision enemy);
    }
}
