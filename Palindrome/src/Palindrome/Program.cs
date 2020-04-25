using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word, phrase, or sentence.");
            var input = Console.ReadLine();
            var palindromeChecker = new PalindromeChecker(input);

            if (palindromeChecker.IsPalindrome)
            {
                Console.WriteLine($"{input} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is not a palindrome.");
            }
        }
    }
}
