using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfSums
{
    class SumOfSums
    {
        public static int SumOfSums(int input)
        {
            int sum = 0;
            int totalSum = 0;
            string strInput = input.ToString();
            for (int i = 0; i <= strInput.Length; i++)
            {
                sum += (input % 10);
                input = input / 10;
            }
            totalSum = (sum % 10);
            sum /= 10;
            totalSum += sum;
            return totalSum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfSums(159489491));
            Console.ReadLine();
        }
    }
}
