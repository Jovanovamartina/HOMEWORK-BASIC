using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue <int> numbers = new Queue <int> ();
            while (true)
            {
                Console.Write("Enter a number please : ");
                if (!int.TryParse(Console.ReadLine(), out int num))
                {
                    Console.WriteLine("Input is not a number , please enter a number");
                    Console.ReadLine();
                    continue;
                }
                numbers.Enqueue(num);
                Console.WriteLine("Would you like to enter a different number (yes/no) ? ");
                string input = Console.ReadLine();
                if (input.ToLower() != "yes")
                {
                    break;
                }
                continue;
            }
            while (numbers.TryDequeue(out int num))
            {
                Console.WriteLine(num);
            }
        }
    }
}
