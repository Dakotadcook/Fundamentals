using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofOdds
{
    public class SumOdds
    {
        public static int GetOddSum(int maxValue)
        {
            int sum = 0;
            for (int i = 0; i <= maxValue; i++)
            {

                if( i % 2 > 0)
                {
                    sum += i;
                }

            }
            return sum;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("GetOddSum.Main()");
            Console.WriteLine(GetOddSum(9));
            Console.ReadLine();
        }
    }
}
