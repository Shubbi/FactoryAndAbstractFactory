namespace DesignPatterns.AbstractFactory
{
    public class BmwFactory : AbstractFactory
    {
        public override Auto CreateAuto()
        {
            return new BmwCar { Name="Bmw - Car" };
        }

        public override Cycle CreateCycle()
        {
            return new BmwCycle { Name = "Bmw- Cycle"};
        }
    }
}
