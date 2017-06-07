namespace DesignPatterns.AbstractFactory
{
    public class HondaFactory : AbstractFactory
    {
        public override Auto CreateAuto()
        {
            return new HondaCar { Name = "Honda - Car"};
        }

        public override Cycle CreateCycle()
        {
            return new HondaCycle { Name = " Honda - Cycle"};
        }
    }
}
