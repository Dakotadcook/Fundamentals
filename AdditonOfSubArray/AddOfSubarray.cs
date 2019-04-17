using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditonOfSubArray
{
    class AddOfSubarray
    {
        public static int AddOfSubArray(int[] input)
        {
            int x = input[0] + input[1];
            for (int i = 1; i < input.Length - 1; i++)
            {
                if (x < input[i] + input[i+1])
                {
                    x = input[i] + input[i + 1];
                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            int[] input = {-2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(AddOfSubArray(input));
            Console.ReadLine();
        }
    }
}