namespace DesignPatterns.AbstractFactory
{
    public class AutoWorld
    {
        public Cycle Cycle { get; }
        public Auto Auto { get; }

        public AutoWorld(AbstractFactory factory)
        {
            Cycle = factory.CreateCycle();
            Auto = factory.CreateAuto();
        }
    }
}
