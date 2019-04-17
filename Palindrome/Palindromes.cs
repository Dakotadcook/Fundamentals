using System;

namespace Palindrome
{
    class Palindromes
    {
        static bool Palindrome(string input)
        {
            input = input.ToLower();
            string revInput = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                revInput += input[i];
            }
            if (input == revInput)
                return true;
            return false;
        }
        static bool PalinDrome(string input)
        {
            input = input.ToLower();
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Palindrome("woow"));
            Console.ReadLine();
        }
    }
}
