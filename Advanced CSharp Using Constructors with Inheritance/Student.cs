using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealingWithConstructors
{
    class Student : Person
    {
        public Student(string name)
            :base(name)
        {

        }

        public int GradeLevel { get; set; }
    }
}
