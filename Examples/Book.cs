using System;
using System.Collections.Generic;

namespace examples
{
    public class Book
    {
        public List<Student> StudentList { get; set; }

        public void Add(Student student)
        {
            StudentList.Add(student);
        }

        public void Dump()
        {
            foreach (var student in StudentList)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}