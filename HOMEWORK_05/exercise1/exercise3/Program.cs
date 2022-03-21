using System;

namespace ageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your Birthday in the following format dd/mm/yy:");
            string dateOfBirth = Console.ReadLine();
            if (dateOfBirth.Length != 8 || int.Parse(dateOfBirth.Substring(0, 2)) > 31 || int.Parse(dateOfBirth.Substring(3, 2)) > 12)
            {
                Console.WriteLine("Wrong format. Please insert your date of birth like this: " +
                    "\n15.05.95 or 08/08/08 or 03-11-87 \nWith separating sign and  zeros no matter the number.");
            }
            else
                CalculateAge(dateOfBirth);
                Console.WriteLine(CalculateAge(dateOfBirth));
            Console.ReadLine();



        }

        static int CalculateAge(string birthDate)
        {
            int age = 0;
            int birthYear;
            int dateOfBirth = int.Parse(birthDate.Substring(0, 2));
            int monthOfBirth = int.Parse(birthDate.Substring(3, 2));
            int yearOfBirth = int.Parse(birthDate.Substring(6, 2));
            int dateNow = int.Parse(DateTime.Now.Day.ToString());
            int monthNow = int.Parse(DateTime.Now.Month.ToString());
            int yearNow = int.Parse(DateTime.Now.Year.ToString());
            
            if (yearOfBirth < 22)
            {
                birthYear = (2000 + yearOfBirth);
            }
            else birthYear = (1900 + yearOfBirth);
            
            if (dateOfBirth > monthNow)
            {
                age = yearNow - birthYear;
            }
            else if (monthOfBirth == monthNow && birthYear > dateNow)
            {
                age = yearNow - birthYear;
            }
            else if (monthOfBirth < monthNow)
            {
                age = yearNow - birthYear;
            }
            else if (monthOfBirth == monthNow && dateOfBirth <= dateNow)
            {
                age = yearNow - birthYear;
            }
            return age;
        }

    }
}
