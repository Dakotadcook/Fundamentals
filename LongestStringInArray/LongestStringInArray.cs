using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestStringInArray
{
    class LongestStringInArray
    {
        public static string LargestString(string[] input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length > output.Length)
                {
                    output = input[i];
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            string[] input = { " Bub", "john", "duhn", "a", "jacob", "colby", "cody", "dak", "Dakota", "LongestName" };
            Console.WriteLine(LargestString(input));
            Console.ReadLine();
        }
    }
}
