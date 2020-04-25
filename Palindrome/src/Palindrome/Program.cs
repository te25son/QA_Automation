using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a word, phrase, or sentence. Press 'q' to quit.");
                var input = Console.ReadLine();

                if (input.Equals("q"))
                {
                    break;
                }

                var palindromeChecker = new PalindromeChecker(input);

                if (palindromeChecker.IsPalindrome)
                {
                    Console.WriteLine($"{input} is a palindrome.\n");
                }
                else
                {
                    Console.WriteLine($"{input} is not a palindrome.\n");
                }
            }
        }
    }
}
