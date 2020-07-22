using System.Collections.Generic;

namespace Lessons.Lesson01
{
    public class Book
    {
        public List<double> grades { get; private set; }

        public Book()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public double GetAverageGrade()
        {
            var result = 0.0;
            foreach (var number in grades)
            {
                result += number;
            }
            return result /= grades.Count;
        }
    }
}
