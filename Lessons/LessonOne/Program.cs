using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace LessonOne
{
    class Program
    {
        static void Main(string[] args)
        {
			var book = new Book();
			book.AddGrade(12.7);
			var average = book.GetAverageGrade();
            Console.WriteLine(average);
		}
    }
}
