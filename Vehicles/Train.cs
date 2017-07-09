using Vehicles_good_preparation.Properties;

namespace Vehicles
{
    public class Train : VehicleWithWheels
    {
        public Train(string producer, int numberOfWheels) : base(producer, numberOfWheels)
        {
        }

        public override string Describe()
        {
            return "This is train produced by " + Producer;
        }
    }
}