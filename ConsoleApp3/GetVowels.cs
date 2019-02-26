using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class GetVowels
    {
        public static int GetVowel(string newinput)
        {
            int num = 0;
            string input = newinput.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    num++;
                }
            }
            return num;
        }
        public static int GetWordCount(string input)
        {
            int num = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    num++;
                }
            }
            return num;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowel("Ee?"));
            //Console.WriteLine(GetWordCount("Get my number of spaces bro"));
            Console.ReadLine();
        }
    }
}
