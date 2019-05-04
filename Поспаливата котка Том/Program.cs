using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int holidays = int.Parse(Console.ReadLine());
            int timeForGame = 30000;
            //conditions

            int holidaysMint = holidays * 127;
            int workGame = (365 - holidays) * 63;
            int fullgame = workGame + holidaysMint;
            int different = timeForGame - fullgame;
            
            int hours = Math.Abs(different / 60);
            int minut = Math.Abs(different % 60);

            if (fullgame <= timeForGame)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hours, minut);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hours, minut);

                
            }
        }
    }
}
