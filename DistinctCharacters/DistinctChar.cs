using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctCharacters
{
    class DistinctChar
    {
        public static int GetCharacters(string input)
        {
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                
                int distinct = 0;
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                        distinct++;
                    if (j == input.Length - 1)
                    {
                        Console.Write(input[i]);
                        Console.Write(distinct);
                    }
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetCharacters("Mississippi"));
            Console.ReadLine();
        }
    }
}
