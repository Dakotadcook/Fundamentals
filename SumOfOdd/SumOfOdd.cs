using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOdd
{
    public class SumOdd
    {
        public static int SumOfOdd(int input)
        {
            int answer = 0;
            for (int i = 0; i <= input; i++)
            {
                if (i % 2 == 1)
                {
                    answer += i;
                }
            }
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfOdd(9));
            Console.ReadLine();
        }
    }
}
