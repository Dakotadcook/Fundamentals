using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInt
{
    class RomanToInt
    {
        public static int RomanInt(string s)
        {
            int Value = 0;
            int sum = 0;
            int preVal = 0;
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'I':
                        Value = 1;
                        break;
                    case 'V':
                        Value = 5;
                        break;
                    case 'X':
                        Value = 10;
                        break;
                    case 'L':
                        Value = 50;
                        break;
                    case 'C':
                        Value = 100;
                        break;
                    case 'D':
                        Value = 500;
                        break;
                    case 'M':
                        Value = 1000;
                        break;
                }
                sum += Value;
                if (preVal < Value)
                {
                    sum -= (preVal * 2);
                }
                preVal = Value;
            }
            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(RomanInt("MCMXCVI"));
            Console.WriteLine(RomanInt("XXII"));
            Console.ReadLine();
        }
    }
}
