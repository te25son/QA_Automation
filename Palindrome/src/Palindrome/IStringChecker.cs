namespace Palindrome
{
    public interface IStringChecker
    {
        string String { get; set; }

        string RemovePunctuation();
        string RemoveWhitespace();
    }
}