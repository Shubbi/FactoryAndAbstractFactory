namespace DesignPatterns.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract Auto CreateAuto();
        public abstract Cycle CreateCycle();
    }
}
