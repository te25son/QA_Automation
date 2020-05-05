using System;
using System.Collections.Generic;

namespace examples
{
    class Program
    {
        static void Enroll(out Student student)
        {
            student = new Student();
            student.Enrolled = false;
        }

        static void Main(string[] args)
        {
            var book = new Book();
            book.StudentList = new List<Student>
            {
                new Student { Name = "Frodo" },
                new Student { Name = "Bilbo" }
            };
            book.Dump();
        }
    }
}
