namespace DesignPatterns.Factory
{
    public class Creator
    {
        private readonly IVehicleFactory _vehicleFactory;

        public Creator(IVehicleFactory vehicleFactory)
        {
            _vehicleFactory = vehicleFactory;
        }

        public IVehicle Create()
        {
            return _vehicleFactory.CreateVehicle();
        }
    }
}
