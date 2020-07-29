using System;
using System.Collections.Generic;
using System.Linq;

namespace Lessons.Lesson04
{
    using static Console;

    public class LambdaExpressionsBefore
    {
        public static void Run()
        {
            var people = new List<Person>
            {
                new Person("Frodo"),
                new Person("Samwise"),
                new Person("Gandalf"),
                new Person("Gimly")
            };

            foreach (var person in people.Where(NameStartsWithG))
            {
                WriteLine(person.Name);
            }
        }

        private static bool NameStartsWithG(Person person)
        {
            return person.Name.StartsWith("G");
        }
    }

    public class LambdaExpressionsAfter
    {
        public static void Run()
        {
            var people = new List<Person>
            {
                new Person("Frodo"),
                new Person("Samwise"),
                new Person("Gandalf"),
                new Person("Gimly")
            };

            foreach (var person in people.Where(p => p.Name.StartsWith("G")))
            {
                WriteLine(person.Name);
            }
        }
    }
}
