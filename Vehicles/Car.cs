namespace Vehicles
{
    public class Car : IVehicle
    {
        private int wheel;
        private string brand;
        private string model;
        private int number;

        public int getW()
        {
            return wheel;
        }

        public int Velocity(int z, int k)
        {
            int w = z + k;
            int m = 10;
            return k / z;
        }

        public string DescribeIt(int z)
        {
            return "This is car with " + number;
        }

        public int GetLength()
        {
            throw new System.NotImplementedException();
        }

        public string GetName()
        {
            return "";
        }

        public int GetVelocity()
        {
            return 0;
        }

        public string SetName()
        {
            throw new System.NotImplementedException();
        }
    }
}
