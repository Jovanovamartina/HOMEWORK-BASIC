using Classes;
using System;

namespace Homework
{
    internal class Program
    {
        public static void CarRacing()
        {
            //objects Car
            Car car1 = new Car("Hyundai", 280);
            Car car2 = new Car("Mazda", 290);
            Car car3 = new Car("Ferrari", 320);
            Car car4 = new Car("Porsche", 380);
            // objects Driver
            Driver driver1 = new Driver("Bob", 3);
            Driver driver2 = new Driver("Greg", 2);
            Driver driver3 = new Driver("Jill", 4);
            Driver driver4 = new Driver("Anne", 5);

            Console.WriteLine("\nPlayer 1 please  choose your car and driver!");
            Car carOne = ChooseCar(car1,car2,car3,car4);
            carOne.Driver = ChooseDriver(driver1,driver2,driver3,driver4);

            Console.WriteLine("\nPlayer 2 please choose your car and driver!");
            Car carTwo = ChooseCar(car1, car2, car3, car4);
            carTwo.Driver = ChooseDriver(driver1, driver2, driver3, driver4);

            Car winner = TheRace(carOne, carTwo);

            Console.WriteLine($"\nDriver : {winner.Driver.Name}, driving : {winner.Model} is the winner with {winner.Speed}km/h");
        }
        public static Driver ChooseDriver(Driver driver1, Driver driver2, Driver driver3, Driver driver4)
        {
            Console.WriteLine("\nChoose your driver.");

            if (driver1.IsChosen)
            {
                Console.WriteLine($"{driver1.Name} , skill level {driver1.Skill}");
            }
            else if (driver2.IsChosen)
                {
                Console.WriteLine($"{driver2.Name} , skill level : {driver2.Skill}");
                }
            else if (driver3.IsChosen)
            {
                Console.WriteLine($"{driver3.Name} , skill level : {driver3.Skill}");
            }
            else
            {
                Console.WriteLine($"{driver4.Name} , skill level : {driver4.Skill}");
            }

            while (true)
            {
                Console.Write("Input driver number you want to select : ");
                if (!int.TryParse(Console.ReadLine(), out int selection) || selection < 1 || selection > 4)
                {
                    Console.WriteLine("Invalid number");
                    continue;
                }
                else if (driver1.IsChosen)
                {
                    Console.WriteLine("Driver already selected , choose another driver!");
                    continue;
                }
                else if (driver2.IsChosen)
                {
                    Console.WriteLine("Driver already selected , choose another driver!");
                    continue;
                }
                else if (driver3.IsChosen)
                {
                    Console.WriteLine("Driver already selected , choose another driver!");
                    continue;
                }
                else if (driver4.IsChosen)
                {
                    Console.WriteLine("Driver already selected , choose another driver!");
                    continue;
                }

                if (driver1.IsChosen == true)
                {
                    return driver1;
                }
                else if(driver2.IsChosen == true)
                {
                    return driver2;
                }
                else if (driver3.IsChosen == true)
                {
                    return driver3;
                }
                else
                {
                    return driver4;
                }

            }
        }

        public static Car ChooseCar(Car car1,Car car2,Car car3,Car car4)
        {
            Console.WriteLine("\nChoose a car.");
            
            
           if (car1.IsChosen)
                {
                    Console.WriteLine($"{car1.Model} , speed : {car1.Speed}km/h ");
                }
            else if (car2.IsChosen)
                {
                    Console.WriteLine($"{car2.Model} , speed : {car2.Speed}km/h");
                }
             else if (car3.IsChosen)
                {
                Console.WriteLine($"{car3.Model} , speed : {car3.Speed}km/h");
                  }
            else
                {
                Console.WriteLine($"{car4.Model} , speed : {car4.Speed}km/h");

            }
           while (true)
            { 
                Console.Write("Enter car number you want to select : ");
            if (!int.TryParse(Console.ReadLine(), out int selection) || selection < 1 || selection > 4)
            {
                Console.WriteLine("Invalid number");
                continue;
            }
            else if (car1.IsChosen)
            {
                Console.WriteLine("Car is selected , choose another car!");
                continue;
            }
            else if (car2.IsChosen)
            {
                Console.WriteLine("Car is selected , choose another car!");
                continue;
            }
            else if (car3.IsChosen)
            {
                Console.WriteLine("Car is selected , choose another car!");
                continue;
            }
            else if (car4.IsChosen)
            {
                Console.WriteLine("Car is selected , choose another car!");
                continue;
            }

            if (car1.IsChosen == true)
            {
                return car1;
            }
            else if (car2.IsChosen == true)
            {
                return car2;
            }
            else if (car3.IsChosen == true)
            {
                return car3;
            }
            else
            {
                return car4;
            }
        }
    }
        public static Car TheRace(Car carOne, Car carTwo)
        {
            if (carOne.CalculateSpeed() > carTwo.CalculateSpeed())
            {
                return carOne;
            }
            return carTwo;
        }

        static void Main(string[] args)
        {

            CarRacing();

            while (true)
            {
                Console.Write("Would you like to race again (yes/no)? ");
                string input = Console.ReadLine();
                if (input.ToLower() != "yes")
                {
                    Console.WriteLine("Thank you and have a nice day!");
                    break;

                }
                CarRacing();
                continue;

            }
        }
    }
}