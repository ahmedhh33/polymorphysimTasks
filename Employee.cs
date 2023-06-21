using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysim
{
    internal abstract class Employee
    {
        protected string name;
        protected double salary;

        public Employee(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public abstract double CalculateBonus();
    }
    class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, double salary) : base(name, salary)
        {
        }

        public override double CalculateBonus()
        {
            return salary * 0.1;
        }
    }

    class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name, double salary) : base(name, salary)
        {
        }

        public override double CalculateBonus()
        {
            return salary * 0.05;
        }
    }

}
