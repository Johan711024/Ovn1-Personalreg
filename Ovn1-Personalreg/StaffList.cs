using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn1_Personalreg
{
    internal class StaffList
    {
        private List<Employee> staffList;
        public StaffList()
        {
            staffList = new List<Employee>();
        }
        public void AddEmployee(string name, int salary)
        {
            staffList.Add(new Employee(name, salary));
        }
        public List<Employee> GetEmployees()
        {
            return staffList;
        }
        
    }
}
