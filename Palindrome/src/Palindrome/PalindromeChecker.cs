using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindrome
{
    public class PalindromeChecker : StringChecker
    {
        public PalindromeChecker(string input) 
            : base(input)
        {
            _inputValue = input.ToLower();
        }

        public string _inputValue { get; set; }

        public string _withoutWhitespace 
        {  
            get { return RemoveWhitespace(); }
            set { _inputValue = value; }
        }

        public string _withoutPunctuation 
        { 
            get { return RemovePunctuation(); }
            set { _inputValue = value; }
        }
        
        public string _reversed 
        { 
            get { return ReverseString(); }
            set { _inputValue = value; }
        }

        public bool IsPalindrome 
        {
            get
            {
                _inputValue = _withoutPunctuation;
                _inputValue = _withoutWhitespace;

                var copy = _inputValue;

                _inputValue = _reversed;

                return copy.Equals(_inputValue);
            } 
        }
    }
}
