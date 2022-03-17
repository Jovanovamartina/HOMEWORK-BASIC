using System;

namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // the easy way :D
            DateTime BirthDay = Convert.ToDateTime("06/03/1995");
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDay.Year;

            if (BirthDay > today.AddYears(-age)) age--;
            Console.WriteLine(age);
            Console.ReadLine();
         }
    }
}
