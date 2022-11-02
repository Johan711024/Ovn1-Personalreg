using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn1_Personalreg
{
    internal class Employee
    {
        public string Name { get; }
        public int Salary { get; }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary= salary;
        }
        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }

    }
    
}
