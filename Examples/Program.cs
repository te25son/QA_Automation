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
        static void Main(string[] args)
        {
            var book = new Book();
            book.ItemList = new List<Student>();
            book.Add(new Student { Name = "Frodo" });
            book.Add(new Student { Name = "Bilbo" });
            book.Dump();

            var book2 = new Book();
            book.ItemList = new List<Employee>();
            book2.Add(new Employee { Name = "Gandalf" });
            book2.Dump();
        }
    }
}
