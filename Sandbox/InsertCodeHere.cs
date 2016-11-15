using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            //Employee
            List<Employee> listOfEmployees = new List<Employee>();

            Worker worker1 = new Worker("John", 2000, "Truck Driver");
            Worker worker2 = new Worker("Tom", 4000, "Service");

            listOfEmployees.Add(worker1);
            listOfEmployees.Add(worker2);


            Manager manager1 = new Manager("George", 5000, 1820);
            Manager manager2 = new Manager("Poul", 6000, 1000);
            
            listOfEmployees.Add(manager1);
            listOfEmployees.Add(manager2);
            manager1.SetHoursWorked(200);
            manager2.SetHoursWorked(180);

            Director director1 = new Director("Michael", 50000);
            Director director2 = new Director("Anders", 20000);

            listOfEmployees.Add(director1);
            listOfEmployees.Add(director2);
            director1.SetHoursWorked(500);
            director2.SetHoursWorked(300);
            // Add you test of the Employee class and derived classes here

            foreach (Employee e in listOfEmployees)
            {
                Console.WriteLine($"{e.GetName()} has a salary of {e.GetSalaryPerMonth()}");
                Console.WriteLine();
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}
