using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class SalesPerson : Employee
    {
        private double SalesRevenue { get; set; }

        public SalesPerson(string firstName, string lastName)
            : base(firstName, lastName, Role.Sales, 750)
        {
            SalesRevenue = 0;
        }
        public void AddSalesRevenue(double revenue)
        {
            SalesRevenue += revenue;
        }
        public override double GetSalary()
        {
            double bonus = 750;
            if (SalesRevenue > 3000 && SalesRevenue <= 6000)
            {
                bonus = 1500;
            }
            else if (SalesRevenue > 6000)
            {
                bonus = 2000;
            }
            return Salary + bonus;
        }
    }
}

