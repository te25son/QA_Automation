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

            var numbers = new[] { 1, 2, 3 };
            query.WriteEach();
            numbers.WriteEach();
        }
    }

    public static class Extensions
    {
        public static IEnumerable<string> StringsThatStartWith(this IEnumerable<string> source, string start)
        {
            foreach (var enumerable in source)
            {
                if (enumerable.StartsWith(start))
                {
                    yield return enumerable;
                }
            }
        }

        public static void WriteEach<T>(this IEnumerable<T> source)
        {
            foreach (var enumerable in source)
            {
                WriteLine(enumerable);
            }
        }
    }
}
