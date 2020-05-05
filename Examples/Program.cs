using System;
using System.Collections.Generic;

namespace examples
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    class Program
    {
        static void Enroll(out Student student)
        {
            student = new Student();
            student.Enrolled = false;
        }

        static void Main(string[] args)
        {
            var book = new Book<Student>();
            book.ItemList = new List<Student>
            {
                new Student { Name = "Frodo" },
                new Student { Name = "Bilbo" }
            };
            book.Dump();

            var book2 = new Book<Employee>();
            book2.ItemList = new List<Employee>();
            book2.Add(new Employee { Name = "Gandalf" });
            book2.Dump();
        }
    }
}
