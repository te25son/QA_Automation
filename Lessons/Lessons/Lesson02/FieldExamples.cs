using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lessons.Lesson02
{
    using static Console;

    public static class FieldExamples
    {
        public static void Run()
        {
            var person1 = new Person();
            var person2 = new Person();

            WriteLine(person1.Name);
            WriteLine(person2.Name);

            // instance field
            person1.Name = "John";

            WriteLine(person1.Name);
            WriteLine(person2.Name);

            // static field
            var weekday1 = Weekdays.Monday;

            WriteLine(weekday1);

            // Modify the static field
            Weekdays.Monday = "Saturday";

            // Reference the static object to a new variable
            var weekday2 = Weekdays.Monday;
            var weekday3 = Weekdays.Monday;

            WriteLine(weekday1);
            WriteLine(weekday2);
        }
    }

    public class Person
    {
        public string Name = "Bob";
    }

    public class Weekdays
    {
        public static string Monday = "Monday";
    }
}
