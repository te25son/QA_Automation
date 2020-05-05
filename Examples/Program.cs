using System;

namespace examples
{
    public delegate void EnrollStudent(Student student);
    class Program
    {
        static void Enroll(out Student student)
        {
            student = new Student();
            student.Enrolled = false;
        }

        static void Main(string[] args)
        {
            Student student;
            Enroll(out student);

            Console.WriteLine(student.Enrolled);
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public bool Enrolled { get; set; }
    }
}
