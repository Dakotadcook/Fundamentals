using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumRepeating
{
    class Program
    {
        public static void DoStuff(int[] nums)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    counter++;
            }
            int k = 0;
            for (int i = 0; i < counter; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    i--;
                    nums[nums.Length - 1 - k] = 0;
                    k++;
                }
                if (k == counter)
                    break;
            }
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 0, 1 };
            DoStuff(nums);
        }
    }
}
