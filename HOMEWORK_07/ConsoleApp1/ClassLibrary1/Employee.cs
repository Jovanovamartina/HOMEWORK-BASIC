using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public Role Role { get; set; }
        protected double Salary { get; set; }
        public Employee() { }
        public Employee(string firstName, string lastName, Role role, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }
        public string GetInfo()
        {
            return $"{FullName}";
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
