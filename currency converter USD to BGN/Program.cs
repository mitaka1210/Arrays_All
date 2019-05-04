using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_converter_USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double dolar = double.Parse(Console.ReadLine());

            //conditions

            double BGN = dolar * 1.79549;
            //outpu

            Console.WriteLine("{0:f2}", BGN);
        }
    }
}
