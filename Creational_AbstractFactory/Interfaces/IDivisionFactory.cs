namespace Creational_AbstractFactory.Interfaces
{
    public interface IDivisionFactory
    {
        ILightDivision CreateLightDivision();
        IRegularDivision CreateMediumDivision();
        IEliteDivision CreateHeavyDivision();
    }
}
