using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter_RadiansIndegrees_конвертор_радиани_градуси_
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double radians = double.Parse(Console.ReadLine());

            //condition

            double degrees = radians *  (180 / Math.PI);

            //output
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
