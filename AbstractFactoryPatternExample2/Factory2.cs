namespace AbstractFactoryPatternExample2
{
    public class Factory2 : IProductFactory
    {
        public ICar CreateCar()
        {
            return new MercedesCar();
        }

        public ITv CreateTv()
        {
            return new LgTv();
        }
    }
}
