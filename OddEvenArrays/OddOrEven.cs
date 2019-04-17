using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenArrays
{
    class OddOrEven
    {
        public static int OddOrEvens(int[] input)
        {
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                    count++;
            }
            int[] even = new int[count];
            int[] odd = new int[input.Length - count];
            int k = 0;
            int j = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    even[k] = input[i];
                    k++;
                }
                else
                {
                    odd[j] = input[i];
                    j++;
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", even));
            Console.WriteLine("[{0}]", string.Join(", ", odd));
            return 0;
        }
        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine(OddOrEvens(input));
            Console.ReadLine();
        }
    }
}
