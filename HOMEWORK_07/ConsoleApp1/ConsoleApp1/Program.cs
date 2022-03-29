using ClassLibrary1;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("Sofia", "Smith", 1700, "IT");
            manager1.AddBonus(2000);

            Manager manager2 = new Manager("Melanija", "Trump", 2700, "HR");
            manager2.AddBonus(5000);

            Contractor contractor1 = new Contractor("Justin", "Beiden", 12, manager1);
            contractor1.AddWorkHours(2);
            contractor1.AddWorkHours(8);
            

            Contractor contractor2 = new Contractor("Martin", "Dow", 12, manager2);
            contractor2.AddWorkHours(4);
            contractor2.AddWorkHours(10);
      

            SalesPerson salesPerson = new SalesPerson("Ana", "Kunis");
            salesPerson.AddSalesRevenue(400);
            salesPerson.AddSalesRevenue(2000);
            salesPerson.AddSalesRevenue(500);

            Employee[] Company = new Employee[] {
                manager1,
                manager2,
                contractor1,
                contractor2,
                salesPerson
            };

            CEO DominicBarton = new CEO("Dominic", "Barton", 80000, Company, 400, 50);
            Console.WriteLine("CEO:");
            Console.WriteLine(DominicBarton.GetInfo());
            Console.WriteLine($"The salary of {DominicBarton.FullName} is : {DominicBarton.GetSalary():C}");
            Console.WriteLine("Employees : ");
            DominicBarton.PrintEmployees();
        }
    }
}
