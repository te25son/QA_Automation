using System;

namespace Lessons.Lesson04
{
    using static Console;

    public class BasicDelegates
    {
        public static void Run()
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) =>
            {
                var temp = x + y;
                return temp;
            };

            WriteLine(square(2));

            Action<int> print = x => WriteLine(x);

            print(square(add(2, 2)));

            Predicate<int> isTen = x => x == 10;

            WriteLine(value: isTen(5));
            WriteLine(value: isTen(10));
        }
    }
}
