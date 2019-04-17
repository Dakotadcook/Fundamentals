using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevInt
{
    class Revint
    {
        public static int ReverseInt(int input)
        {
            int revInt = 0;
            while (input > 0)
            {
                revInt *= 10;
                revInt += (input % 10);
                input /= 10;
            }
            return revInt;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseInt(3968));
        }
    }
}
