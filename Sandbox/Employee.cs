using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Employee
    {
        private String name; //instance field
        private int salaryPerMonth; //instance field

        public Employee(String name, int salaryPerMonth) //constructor
        {
            this.name = name;
            this.salaryPerMonth = salaryPerMonth;
        }

        public String GetName() //method
        {
            return name;
        }

        public virtual int GetSalaryPerMonth() //method
        {
            return salaryPerMonth;
        }
    }
}
