using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysim
{
    internal class Students : IComparable<Students>
    {
        public string Name;
        public int Age;

        public Students (string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int CompareTo(Students? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
