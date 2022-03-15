using System;

namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double NumberOne, NumberTwo, NumberThree, NumberFour;

            Console.Write("Enter the First number: ");
            NumberOne = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Second number: ");
            NumberTwo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the third number: ");
            NumberThree = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the fourth number: ");
            NumberFour = Convert.ToDouble(Console.ReadLine());

            double result = (NumberOne + NumberTwo + NumberThree + NumberFour) / 4;
            Console.WriteLine(result);
        }
    }
}
