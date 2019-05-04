using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace currency_converter_BGN_USD_EUR_GBP_
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            string firstvalut = Console.ReadLine();
            string secondvalut = Console.ReadLine();

            double course = 0.0;
            if (firstvalut == "BGN" && secondvalut == "USD")//BGN to USD
            {
                course = 1;
                double mix = money * course;
                Console.WriteLine("{0:f2} USD", mix / 1.79549);
            }
            if (firstvalut == "BGN" && secondvalut == "EUR")//BGN to EUR
            {
                course = 1;
                double mix = money * course;
                Console.WriteLine("{0:f2} EUR", mix / 1.95583);
            }
            if (firstvalut == "BGN" && secondvalut == "GBP")//BGN to GBP
            {
                course = 1;
                double mix = money * course;
                Console.WriteLine("{0:f2} GBP", mix / 2.53405);
            }
            if (firstvalut == "USD" && secondvalut == "EUR")//USD to EUR
            {
                course = 1.79549;
                double mix = money * course;
                Console.WriteLine("{0:f2} EUR", mix / 1.95583);
            }
            if (firstvalut == "USD" && secondvalut == "BGN")//USD to BGN
            {
                course = 1.79549;
                double mix = money * course;
                Console.WriteLine("{0:f2} BGN", mix / 1);
            }
            if (firstvalut == "USD" && secondvalut == "GBP")//USD to GBP
            {
                course = 1.79549;
                double mix = money * course;
                Console.WriteLine("{0:f2} GBP", mix / 2.53405);
            }
            if (firstvalut == "EUR" && secondvalut == "BGN")//EUR to BGN
            {
                course = 1.95583;
                double mix = money * course;
                Console.WriteLine("{0:f2} BGN", mix / 1);
            }
            if (firstvalut == "EUR" && secondvalut == "USD")//EUR to USD
            {
                course = 1.95583;
                double mix = money * course;
                Console.WriteLine("{0:f2} USD", mix / 1.79549);
            }
            if (firstvalut == "EUR" && secondvalut == "GBP")//EUR to GBP
            {
                course = 1.95583;
                double mix = money * course;
                Console.WriteLine("{0:f2} GBP", mix / 2.53405);
            }
            if (firstvalut == "GBP" && secondvalut == "USD")//GBP to USD
            {
                course = 2.53405;
                double mix = money * course;
                Console.WriteLine("{0:f2} USD", mix / 1.79549);
            }
            if (firstvalut == "GBP" && secondvalut == "EUR")//GBP to EUR
            {
                course = 2.53405;
                double mix = money * course;
                Console.WriteLine("{0:f2} EUR", mix / 1.95583);
            }
            if (firstvalut == "GBP" && secondvalut == "BNG")//GBP to BGN
            {
                course = 2.53405;
                double mix = money * course;
                Console.WriteLine("{0:f2} BGN", mix / 1);
            }
        }
    }
}
