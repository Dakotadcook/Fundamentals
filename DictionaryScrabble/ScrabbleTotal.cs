using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryScrabble
{
    class ScrabbleTotal
    {

        public static int GetScrabbleTotal(string input)
        {
            input = input.ToUpper();
            Dictionary<char, int> myDict = new Dictionary<char, int>();
            myDict.Add('A', 1); myDict.Add('E', 1); myDict.Add('I', 1);
            myDict.Add('O', 1); myDict.Add('U', 1); myDict.Add('L', 1);
            myDict.Add('N', 1); myDict.Add('S', 1); myDict.Add('T', 1);
            myDict.Add('R', 1);
            myDict.Add('D', 2); myDict.Add('G', 2);
            myDict.Add('B', 3); myDict.Add('C', 3); myDict.Add('M', 3);
            myDict.Add('F', 4); myDict.Add('H', 4); myDict.Add('V', 4);
            myDict.Add('K', 5);
            myDict.Add('J', 8); myDict.Add('X', 8);
            myDict.Add('Q', 10); myDict.Add('Z', 10);
            int sum = 0;
            foreach (char i in input)
            {
                sum += myDict[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetScrabbleTotal("DakotaCook"));
            Console.ReadLine();
        }
    }
}
