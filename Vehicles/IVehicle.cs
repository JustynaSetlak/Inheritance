namespace Vehicles
{
    public interface IVehicle
    {
        string DescribeIt(int z);
        int Velocity(int z, int k);
        int GetLength();
        string GetName();
        int GetVelocity();
        string SetName();
    }
}