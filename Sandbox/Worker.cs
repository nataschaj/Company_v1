using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker:Employee
    {
        private string truckDriver;
        private string maintenance;

        public Worker(string name, int salaryPerMonth) : base(name, salaryPerMonth)
        { 
        }

        Worker worker1 = new Worker("John", 1230);
    }
}
