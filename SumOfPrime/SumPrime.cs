using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrime
{
    class SumPrime
    {
        public static bool IsPrime(int input)
        {
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int SumOfPrime(int input)
        {
            int answer = 0;
            for (int i = 2; i <= input; i++)
            {    
                if (IsPrime(i))
                {
                    answer += i;
                }
            }

            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfPrime(10));
            Console.ReadLine();
        }
    }
}
