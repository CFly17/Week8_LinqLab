using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Week8_LinqLab
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }
}
