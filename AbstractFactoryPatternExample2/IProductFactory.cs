namespace AbstractFactoryPatternExample2
{
    public interface IProductFactory
    {
        ICar CreateCar();
        ITv CreateTv();
    }
}
