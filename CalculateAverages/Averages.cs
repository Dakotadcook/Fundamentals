using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAverages
{
    class Averages
    {
        static double TestAverages( double A, double B, double C)
        {
            int i = 3;
            double sum;
            sum = A + B + C;

            return sum / i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Averages.Main()");
            Console.WriteLine($"{TestAverages(90.0, 95.0, 85.0)}");

            Console.ReadLine();
        }
    }
}
