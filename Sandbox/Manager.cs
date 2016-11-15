using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Manager : Employee
    {
        private int monthlyBonus;
        private int hoursWorked;

        public Manager(string name, int salaryPerMonth, int monthlyBonus) : base(name, salaryPerMonth)
        {
            this.monthlyBonus = monthlyBonus;
            hoursWorked = 0;
        }

        public void SetHoursWorked(int hoursWorked)
        {
            this.hoursWorked = hoursWorked;
        }

        public override int GetSalaryPerMonth()
        {
            int totalSalary = base.GetSalaryPerMonth();

            if (hoursWorked > 180)
            {
                totalSalary = totalSalary + monthlyBonus;
            }
            else
            {
                Console.WriteLine("sorry " + GetName() + "! You have not worked enought this month to earn a bonus");
            }

            return totalSalary;
        }
    }
}
