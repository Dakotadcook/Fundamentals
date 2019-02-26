using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailCheck
{
    class EmailCheck
    {
        public static string FindEmail(string input)
        {
            string email = "";
            int x = input.IndexOf('@');
            for (int i = x; i > 0; i--)
            {
                if (input[i] == ' ' || input[i] == input[0])
                {
                    x = i;
                    for (int j = x + 1; j < input.Length; j++)
                    {
                        if (input[j] == ' ' || input[j] == input.Length - 1)
                        {
                            int y = j;
                            for (int k = x + 1; k < y; k++)
                            {
                                email += input[k];
                            }
                            break;
                        }
                    }
                    break;
                }
            }
            return email;
        }
        public static bool IsEmail(string email)
        {
            string[] arr = email.Split('@');
            if (arr[0] == String.Empty || arr[1] == String.Empty)
                return false;
            string[] arr2 = arr[1].Split('.');
            if (arr2[0] == String.Empty || arr2[1] == String.Empty)
                return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsEmail(FindEmail("My Email is dakota.d.cook@ please find it in this string;")));
            Console.ReadLine();
        }
    }
}
