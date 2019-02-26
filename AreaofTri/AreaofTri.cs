using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaofTri
{
    class AreaofTri
    {
        static void TestAOT()
        {
            int howMany = 5;
            for (int i = 0; i < howMany; i++)
            {
                for (int j = 0; j < howMany; j++)
                {
                    Console.Write($"base: {i}, height : {j}  Area: ");
                    Console.WriteLine($"{AreaofTriangle(i, j)}");
                }

            }
        }
        static double AreaofTriangle(double b, double ht)
        {
            return b * ht / 2.0;


        }
        static void Main(string[] args)
        {
            Console.WriteLine("AreaofTri.Main()");
            TestAOT();
            Console.ReadLine();

        }
    }
}
