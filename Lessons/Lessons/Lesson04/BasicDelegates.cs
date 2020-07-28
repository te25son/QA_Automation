using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson04
{
    using static Console;

    public class BasicDelegates
    {
        public void Run()
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (x, y) => x + y;  // Paranthesis needed for more than one parameter.

            WriteLine(square(2));
            WriteLine(add(3, 3));

            Action<int> write = x => WriteLine(x);

            write(square(add(3, 3)));
        }
    }
}
