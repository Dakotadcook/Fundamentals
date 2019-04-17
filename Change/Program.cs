using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change
{
    class Program
    {
        public static string Encrypt(string input, int num)
        {
            num %= 26;
            string[] array = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (j + num < array.Length)
                        Console.Write(array[j + num]);
                    else if(j+num > array.Length)
                    {
                        int temp = (j + num) - (array.Length - 1);
                        Console.Write(array[temp]);
                    }
                   // else
                   // {
                   //     int temp = (array.Length) + (num + j);
                   //     Console.Write(array[temp]);
                   // }
                }
            }
            return input;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Encrypt("Cat", 2));
            Console.ReadLine();
        }
    }
}
