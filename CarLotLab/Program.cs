using System;

namespace CarLotLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool returnToMain = true;

            while (returnToMain)
            {

                CarLot c = new CarLot();
                

                Console.WriteLine("Welcome to Grant Chirpus' Used Car Emproium!\n");
                Console.WriteLine("\nHere is the list of cars\n");

                c.PrintCars();
                Console.WriteLine("\nAdd a car to the lot: \n");
                c.AddCar();
                Console.WriteLine("Remove a car to the lot: \n");
                c.RemoveCar();


                Console.WriteLine("Return to main [y] or [n]");
                string userChoiceToReturn = Console.ReadLine().ToLower();

                if (userChoiceToReturn == "n")
                {
                    returnToMain = false;
                    Console.WriteLine("Thanks, Bye!");
                }

            }

        }
    }
}
