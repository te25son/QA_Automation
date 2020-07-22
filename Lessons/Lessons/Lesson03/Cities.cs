using System.Collections.Generic;
using System.Linq;

namespace Lessons.Lesson03
{
    using static System.Console;

    public class Cities
    {
        public static void Run()
        {
            IEnumerable<string> cities = new[] { "Prague", "New York", "Rome", "Hong Kong", "Paris" };
            IEnumerable<string> query = cities.StringsThatStartWith("P");

            foreach (var item in query)
            {
                WriteLine(item);
            }
        }
    }

    public static class Extensions
    {
        public static IEnumerable<string> StringsThatStartWith(this IEnumerable<string> source, string start)
        {
            foreach (var s in source)
            {
                if (s.StartsWith(start))
                {
                    yield return s;
                }
            }
        }
    }
}
