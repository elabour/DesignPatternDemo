namespace AbstractFactoryPatternExample2
{
    public class Factory1 : IProductFactory
    {
        public ICar CreateCar()
        {
            return new BmwCar();
        }

        public ITv CreateTv()
        {
            return new SamsungTv();
        }
    }
}
