namespace Vehicles_good_preparation.Properties
{
    public abstract class VehicleWithWheels
    {
        public string Producer { get; set; }
        public int  NumberOfWheels { get; set; }

        public VehicleWithWheels(string producer, int numberOfWheels)
        {
            Producer = producer;
            NumberOfWheels = numberOfWheels;
        }

        public virtual double CountVelocity(double time, double distance)
        {
            return distance / time;
        }

        public virtual string Describe()
        {
            return "It is vehicle produced by" + Producer + ", which contains " + NumberOfWheels + "wheels";
        }
    }
}