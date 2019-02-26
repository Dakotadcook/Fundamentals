using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimAngle
{
   public class TimeAngle
    {
        public static int ClockAngle(int hour, int min)
        {        
            int newMin = min * 6;
            int newHour = hour * 30;
            int Angle = (newHour > newMin) ?
            newHour - newMin : newMin - newHour;           
            return Angle;
        }
         
        static void Main(string[] args)
        {
            Console.WriteLine(ClockAngle(9, 1));
            Console.ReadLine();
        }
    }
}
