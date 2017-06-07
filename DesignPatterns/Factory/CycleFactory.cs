namespace DesignPatterns.Factory
{
    class CycleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Cycle {Name = "Cycle"};
        }
    }
}