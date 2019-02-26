using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArrayAlphabetized
{
    class StringArrayAlphabetized
    {
        public static string SortedArray(string[] input)
        {
            
            string temp;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i +1; j < input.Length ; j++)
                {
                    for (int x = 0; x < input.Length ; x++)
                    {
                        if (input[i][x] > input[j][x])
                        {
                            temp = input[j];
                            input[j] = input[i];
                            input[i] = temp;
                        }
                    }

                }

            }
           
        }
        static void Main(string[] args)
        {
            string[] input = { "Cody, John, Dennis, Bob, Alex" };
           
            Console.ReadLine();
        }
    }
}
