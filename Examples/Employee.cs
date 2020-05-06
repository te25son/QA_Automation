using System;
using System.Collections.Generic;
using System.Text;

namespace examples
{
    public class Employee : INamedEntity
    {
        public string Name { get; set; }

        public int Id { get; set; }
    }
}
