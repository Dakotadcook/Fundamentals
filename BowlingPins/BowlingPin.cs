using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingPins
{
    class BowlingPin
    {
        public static void BowlingPins(int pinNum)
        {
            int num = 1;
            int spaces = 1;
            for (int i = 2; i <= pinNum; i++)
            { 
                num += i;
                if (num > pinNum)
                    break;
                spaces++;
            }
            spaces = (spaces * 2) - 2;
            for (int i = 0; i <= pinNum; i++)
            {
                for (int j = 0; j < length; j++)
                {

                }
            }
        }
        static void Main(string[] args)
        {
            BowlingPins(10);
        }
    }
}
