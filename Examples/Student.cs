﻿using System;
using System.Collections.Generic;
using System.Text;

namespace examples
{
    public class Student : INamedEntity
    {
        public string Name { get; set; }

        public bool Enrolled { get; set; }
    }
}
