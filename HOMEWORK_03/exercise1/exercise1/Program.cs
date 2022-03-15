using System;

namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise 1
            int firstNumber;
            int secondNumber;
            string operation;
            int result;
            Console.WriteLine("enter the first number");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter operator ");
            operation = Console.ReadLine();

            if (operation == "x")
            {
                result = firstNumber * secondNumber;
                Console.WriteLine(firstNumber + " x " + secondNumber + " = " + result);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                result = firstNumber / secondNumber;
                Console.WriteLine(firstNumber + " / " + secondNumber + " = " + result);
                Console.ReadLine();
            }

            else if (operation == "+")
            {
                result = firstNumber + secondNumber;
                Console.WriteLine(firstNumber + " + " + secondNumber + " = " + result);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
                Console.WriteLine(firstNumber + " - " + secondNumber + " = " + result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("something is wrong,please enter a valid number and operator");
                Console.ReadLine();
            }
        }
    }
}
