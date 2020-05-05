using System;
using System.Collections.Generic;

namespace examples
{
    public class Book<Student>
    {
        public List<Student> StudentList { get; set; }

        public void Add(Student student)
        {
            StudentList.Add(student);
        }

        public void Dump(List<Student> studentList)
        {
            foreach (var student in studentList)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}