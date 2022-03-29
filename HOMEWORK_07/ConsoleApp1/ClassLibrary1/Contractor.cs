using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Contractor : Employee
    {
        private double WorkHours { get; set; }
        private int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, int payPerHour, Manager responsible)
            : base(firstName, lastName, Role.Contractor, 0)
        {
            WorkHours = 0;
            PayPerHour = payPerHour;
           
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }
        public void AddWorkHours(int hours)
        {
            WorkHours += hours;
        }
      
    }
}

