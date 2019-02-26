using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSorts
    {
        public static void BubbleSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        int temp = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = temp;
                    }
                }
            }
            foreach (int i in input)
                Console.Write(i + " ");
        }
        static void Main(string[] args)
        {
            int[] input = {17, 5};
            BubbleSort(input);
            Console.ReadLine();
        }
    }
}
