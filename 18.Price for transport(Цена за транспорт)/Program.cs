using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Price_for_transport_Цена_за_транспорт_
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double km = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            double stratPrice = 0.70;

            //conditions

            if (dayOrNight == "day" && km < 20)
            {
                double firstOptions = (0.79 * km) + stratPrice; //taxi day
                Console.WriteLine("{0:f2}", firstOptions);
            }
            else if (dayOrNight == "night" && km < 20)
            {
                double firstOptions = (0.90 * km) + stratPrice;//taxi night
                Console.WriteLine("{0:f2}", firstOptions);
            }
            else if (km >= 20 && km < 100)
            {
                double firstOptions = (0.09 * km);
                Console.WriteLine("{0:f2}", firstOptions);//buss
            }
            else if (km > 100)
            {
                double firstOptions = (0.06 * km);
                Console.WriteLine("{0:f2}", firstOptions);//train
            }
            //output
        }
    }
}
