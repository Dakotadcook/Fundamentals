using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimAngle
{
   public class TimeAngle
    {
        public static double ClockAngle(int hour, int min)
        {
            double newHour = hour;
            double newMin = min;
            newHour *=  30;
            newHour += (newMin / 2);
            newMin *= 6;
            return Math.Abs(newMin - newHour);
        }
         
        static void Main(string[] args)
        {
            Console.WriteLine(ClockAngle(3, 45));
            Console.ReadLine();
        }
    }
}
