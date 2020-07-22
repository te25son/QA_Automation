using System;

namespace Lessons.Lesson03
{
    using static Console;

    public static class MyClassExtensions
    {
        public static void M4(this MyClass source)
        {
            WriteLine("This is method four.");
        }

        public static void M5(this MyClass source, string text)
        {
            WriteLine(text);
        }
    }
}
