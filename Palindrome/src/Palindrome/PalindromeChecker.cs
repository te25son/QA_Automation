using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    public class PalindromeChecker
    {
        public PalindromeChecker(string input)
        {
            InputString = input;
        }

        public string InputString { get; set; }

        public string WithoutWhitespaceAndPunctuation
        { 
            get { return RemoveWhitespaceAndPunctuationFromString(InputString); } 
        }

        public string Reversed { 
            get { return ReverseString(InputString); } 
        }

        public bool IsPalindrome {
            get
            {
                var onlyLowerCaseChars = WithoutWhitespaceAndPunctuation.ToLower();
                var onlyLowerCaseCharsReversed = ReverseString(onlyLowerCaseChars);

                return onlyLowerCaseChars.Equals(onlyLowerCaseCharsReversed);
            } 
        }

        private string RemoveWhitespaceAndPunctuationFromString(string value)
        {
            var asCharArray = value.ToCharArray();
            
            return new string(
                asCharArray.Where(c => !Char.IsWhiteSpace(c) && !Char.IsPunctuation(c)).ToArray()
            );
        }

        private string ReverseString(string value)
        {
            var asCharArray = value.ToCharArray();
            Array.Reverse(asCharArray);

            return new string(asCharArray);
        }
    }
}
