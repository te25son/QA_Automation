using System;
using System.Collections.Generic;
using System.Reflection;

namespace examples
{
    public class Student : INamedEntity
    {
        public string Name { get; set; }

        public bool Enrolled { get; set; }
    }

    public class Employee : INamedEntity
    {
        public string Name { get; set; }

        public int Id { get; set; }
    }

    class Program
    {
        static void ConsoleWrite(object value)
        {
            Console.WriteLine(value);
        }

        static void ConsoleWriteType(object value)
        {
            Console.WriteLine(value.GetType().Name);
        }

        static void Main(string[] args)
        {
            var book = new Book<Student>();
            book.Add(new Student { Name = "Frodo" });
            book.Add(new Student { Name = "Bilbo" });
            book.Dump(ConsoleWrite);

            var book2 = new Book<Employee>();
            book2.Add(new Employee { Name = "Gandalf" });
            book2.Dump(ConsoleWriteType);
        }
    }
}
