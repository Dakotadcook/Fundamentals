using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesandFeet
{
    public class InchesandFeet
    {
        public static int Getfeet(int feet)
        {

            return feet * 12;
        }

        public static double InchesToFeet(int inches)
        {
            return (double)inches / 12.0;
        }
          
           
        static void Main(string[] args)
        {
            Console.WriteLine("FeetandInches");
            Console.WriteLine(InchesToFeet(48));
            Console.ReadLine();

        }
    }
}
