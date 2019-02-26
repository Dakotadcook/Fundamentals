using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class camelCase
    {
        public static string CamelCase(string input)
        {
            input = input.ToLower();
            char[] array = input.ToCharArray();
            char letter;
            string answer;
            for (int i = 0; i < array.Length; i++)
            {
                letter = array[i];
             

            }

            answer = input.Trim();
            return input;





        }
        static void Main(string[] args)
        {
            Console.WriteLine(CamelCase("duck and more duckS"));
            Console.ReadLine();
        }
    }
}
