using System;
using System.Collections.Generic;

namespace examples
{
    public delegate void Printer(object value);

    public interface INamedEntity
    {
        string Name { get; set; }
    }

    public class Book<T>
        where T : INamedEntity // Type constraint.
    {
        public Book()
        {
            ItemList = new List<T>();
        }

        public List<T> ItemList { get; set; }

        public void Add(T item)
        {
            ItemList.Add(item);
        }

        public void Dump(Printer print)
        {
            foreach (var item in ItemList)
            {
                print(item.Name);
            }
        }
    }
}
