using System;

namespace exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int FirstNumber, SecondNumber, swap;

                Console.Write("\nInput the First Number : ");
                FirstNumber = int.Parse(Console.ReadLine());

                Console.Write("\nInput the Second Number : ");
                SecondNumber = int.Parse(Console.ReadLine());

                swap = FirstNumber;
                FirstNumber = SecondNumber;
                SecondNumber = swap;

                Console.Write("\nAfter Swapping : ");
                Console.Write("\nFirst Number : " + FirstNumber);
                Console.Write("\nSecond Number : " + SecondNumber);
                Console.Read();
            }
        }
    }
}
