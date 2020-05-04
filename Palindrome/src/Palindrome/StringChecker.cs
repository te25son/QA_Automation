using System;
using System.Linq;

namespace Palindrome
{
    public class StringChecker
    {
        public StringChecker(string value)
        {
            _value = value;
        }

        public string _value { get; set; }

        public string RemoveWhitespace()
        {
            var valueAsCharArray = _value.ToCharArray();

            return new string(
                valueAsCharArray.Where(c => !Char.IsWhiteSpace(c)).ToArray()
            );
        }

        public string RemovePunctuation()
        {
            var valueAsCharArray = _value.ToCharArray();

            return new string(
                valueAsCharArray.Where(c => !Char.IsPunctuation(c)).ToArray()
            );
        }

        public string ReverseString()
        {
            var asCharArray = _value.ToCharArray();
            Array.Reverse(asCharArray);

            return new string(asCharArray);
        }
    }
}