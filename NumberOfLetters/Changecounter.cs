using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfLetters
{
    class Changecounter
    {
        public static double ChangeCounter(String input)
        {
            double Value = 0;
            double answer = 0;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'P':
                        Value = .01;
                        break;
                    case 'N':
                        Value = .05;
                        break;
                    case 'D':
                        Value = .10;
                        break;
                    case 'Q':
                        Value = .25;
                        break;
                }
                answer += Value;
            }
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ChangeCounter("QDPDQQQq"));
            Console.ReadLine();
        }
    }
}
