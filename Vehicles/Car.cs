using Vehicles_good_preparation.Properties;

namespace Vehicles
{
    public class Car : VehicleWithWheels
    {
        public Car(string producer, int numberOfWheels) : base(producer, numberOfWheels)
        {
        }

        public override string Describe()
        {
            return "This is a car, which contains " + NumberOfWheels + " wheels.";
        }
    }
}
