using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Train t = new Train();
            Car c = new Car();

            Console.WriteLine(t.DescribeIt(2));
            Console.WriteLine(c.DescribeIt(2));
            Console.WriteLine(t.GetLength());

            Console.ReadKey();
        }
    }
}
