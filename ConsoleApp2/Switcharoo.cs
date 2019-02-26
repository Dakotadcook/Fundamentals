using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Switcharoo
    {
        public static int reverseint(int val)
        {
            int answer;
            if (val < 0)
            {
                answer = Math.Abs(val);
            }
            else
            {
                int temp = val + val;
                answer = val - temp;
            }
            return answer;
        }
        static void Main(string[] args)
        {
       
            
        }
    }
}
