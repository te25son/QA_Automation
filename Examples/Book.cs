using System;
using System.Collections.Generic;
using System.Text;

namespace examples
{
    public class Book<T>
        where T : INamedEntity
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

        public void Dump()
        {
            foreach (var item in ItemList)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
