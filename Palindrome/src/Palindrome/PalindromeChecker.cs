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

        public string WithoutWhitespaceOrPunctuation { 
            get { return RemoveWhitespaceFromString(InputString); } 
        }

        public string Reversed { 
            get { return ReverseString(InputString); } 
        }

        public bool IsPalindrome {
            get
            {
                var onlyChars = WithoutWhitespaceOrPunctuation.ToLower();
                var onlyCharsReversed = ReverseString(onlyChars);

                return onlyChars.Equals(onlyCharsReversed);
            } 
        }

        private string RemoveWhitespaceFromString(string value)
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
