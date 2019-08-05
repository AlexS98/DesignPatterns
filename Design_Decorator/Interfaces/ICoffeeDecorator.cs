namespace Design_Decorator.Interfaces
{
    public interface ICoffeeDecorator : ICoffee
    {
        ICoffee BaseCoffee { get; set; }
    }
}
