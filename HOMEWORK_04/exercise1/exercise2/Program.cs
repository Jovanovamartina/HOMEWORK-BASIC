using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = {"martina", "ana", "sofia", "melanija", "sara"};
            string[] studentsG2 = {"damjan", "david", "mihail", "daniel", "martin"};

            Console.WriteLine("which group you want to choose?");
            int userInput = int.Parse(Console.ReadLine());
            for (int i=0; i<5; i++)
            {
                if (userInput == 1)
                {
                    Console.WriteLine((i + 1) + ". " + studentsG1[i]);
                }
                else if (userInput == 2)
                {
                    Console.WriteLine((i + 1) + ". " + studentsG2[i]);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
