using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntSwap
{
    class IntSwap
    {
        public static void IntSwap(int a, int b)
        {
            Console.WriteLine($"{a}, {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"{a}, {b}");
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            IntSwap(4, 5);
        }
    }
}
