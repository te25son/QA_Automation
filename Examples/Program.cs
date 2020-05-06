using System;
using System.Collections.Generic;

namespace examples
{
    class Program
    {
        static void Write(object value)  // should be string not object to avoid boxing.
        {
            Console.WriteLine(value);
        }

        static void Main(string[] args)
        {
            var book = new Book<Student>();
            book.Add(new Student { Name = "Frodo" });
            book.Add(new Student { Name = "Bilbo" });
            book.Dump(Write);

            var book2 = new Book<Employee>();
            book2.Add(new Employee { Name = "Gandalf" });
            book2.Dump(Write);
        }
    }
}
