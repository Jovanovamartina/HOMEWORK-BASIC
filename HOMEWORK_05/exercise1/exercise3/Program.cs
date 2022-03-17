using System;
 
namespace exercise3
{
    internal class Program
    {

       
        static void Main(string[] args)
        {

            static int CalculateAgeCorrect(DateTime birthDate, DateTime now)
            {
                int age = now.Year - birthDate.Year;

                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                    age--;

                return age;
            }

        }
    }
}
