using System;
using System.Collections.Generic;

namespace examples
{
    public class Book<T>
    {
        public List<T> ItemList { get; set; };

        public void Add(T item)
        {
            ItemList.Add(item);
        }

        public void Dump()
        {
            foreach(var item in ItemList)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}