using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeOrNote
{
    public class PrimeOrNot
    {
        public static bool IsPrime(long x)
        {
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("Your number is not prime");
                    return false;
                }
            }
            Console.WriteLine("Your number is prime");
            return true;
        
        }
        static void Main(string[] args)
        {
            IsPrime(4);
            IsPrime(2);
            IsPrime(156);
            IsPrime(1000000005741);
            Console.ReadLine();
        }
    }
}
