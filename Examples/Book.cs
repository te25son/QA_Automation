using System;
using System.Collections.Generic;

namespace examples
{
    public class Book<T>
    {
        public List<T> ItemList { get; set; }

        public void Add(T student)
        {
            ItemList.Add(student);
        }

        public void Dump()
        {
            foreach (var item in ItemList)
            {
                if (item.GetType().Equals(typeof(Student)))
                {
                    Console.WriteLine($"I am a student.");
                }
                else
                {
                    Console.WriteLine("I am an employee");
                }
            }
        }
    }
}