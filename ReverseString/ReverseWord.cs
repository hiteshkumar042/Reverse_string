using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    internal class ReverseWord
    {
        public static void Reverse(String word)
        {
            string reverse = "";
            char[] setOfCharacters = word.ToCharArray();
            Console.WriteLine("Displaying each character");
            for (int i = 0; i < setOfCharacters.Length; i++)
            {
                Console.Write(setOfCharacters[i] + " ");
            }
            for (int i = 0; i < setOfCharacters.Length; i++)
            {
                reverse = setOfCharacters[i] + reverse;
            }
            Console.WriteLine("\n" + reverse);

            if (word == reverse)
            {
                Console.WriteLine("It's a Palindrome");
            }
            else
            {
                Console.WriteLine("It's not a palindrome");
            }
        }
    }
}
