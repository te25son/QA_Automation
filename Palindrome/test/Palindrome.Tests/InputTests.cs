using System;
using Xunit;

namespace Palindrome.Tests
{
    public class InputTests
    {
        [Theory]
        [InlineData("A B C", "ABC")]
        [InlineData("1 2 3", "123")]
        public void CanRemoveWhitespace(string input, string expected)
        {
            var palindrome = new PalindromeChecker(input);

            Assert.Equal(expected, palindrome._withoutWhitespace);
        }

        [Theory]
        [InlineData("''A.? B C!", "ABC")]
        [InlineData("1 !2.. 3", "123")]
        [InlineData("!?# ))..", "")]
        public void CanRemovePunctuation(string input, string expected)
        {
            var palindrome = new PalindromeChecker(input);

            Assert.Equal(expected, palindrome._withoutPunctuation);
        }

        [Theory]
        [InlineData("A B C", "C B A")]
        [InlineData("1 2 3", "3 2 1")]
        [InlineData("Bob ate rice", "ecir eta boB")]
        public void CanReverseString(string input, string expected)
        {
            var palindrome = new PalindromeChecker(input);

            Assert.Equal(expected, palindrome._reversed);
        }

        [Theory]
        [InlineData("A")]
        [InlineData("Eve")]
        [InlineData("Dennis and Edna sinned")]
        [InlineData("A man, a plan, a canal, panama.")]
        public void IsPalindromeTrue(string input)
        {
            var palindrome = new PalindromeChecker(input);

            Assert.True(palindrome.IsPalindrome);
        }

        [Theory]
        [InlineData("Be")]
        [InlineData("A tea cup")]
        [InlineData("A man, a canal, a plan, panama.")]
        public void IsPalindromeFalse(string input)
        {
            var palindrome = new PalindromeChecker(input);

            Assert.False(palindrome.IsPalindrome);
        }
    }
}
