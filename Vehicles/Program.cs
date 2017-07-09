using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles_good_preparation.Properties;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleWithWheels train = new Train("Shinkansen", 10);
            VehicleWithWheels car = new Car("Volvo", 4);

            Console.WriteLine(train.Describe());
            Console.WriteLine(train.CountVelocity(10,5));

            Console.WriteLine(car.Describe());
            Console.WriteLine(car.CountVelocity(30,5));

            Console.ReadKey();
        }
    }
}
