namespace Vehicles
{
    public class Train : IVehicle
    {
        private string name;


        public string DescribeIt(int z)
        {
            return "This is train";
        }

        public int Velocity(int z, int k)
        {
            return z / k;
        }

        public int GetLength()
        {
            return 10;
        }

        public string GetName()
        {
            throw new System.NotImplementedException();
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