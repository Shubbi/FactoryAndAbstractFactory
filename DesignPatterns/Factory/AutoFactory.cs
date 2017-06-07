
namespace DesignPatterns.Factory
{
    class AutoFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle()
        {
            return new Auto {Name="Auto"};
        }
    }
}