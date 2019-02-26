using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelCount
{
    class Vowels
    {
        public static int VowelCount(string input)
        {
           
            int vowels = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
                {
                    vowels++;
                }
            }
            return vowels;
        }
        
        static void Main(string[] args)
        {
           
            Console.WriteLine(VowelCount("Dennis I know What I'am talking about dude, I don't need google like you do."));
            Console.ReadLine();
        }
    }
}
