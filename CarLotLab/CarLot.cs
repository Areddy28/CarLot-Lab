using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotLab
{
    class CarLot
    {
        List<Car> Cars { get; set; } = new List<Car>();

        public CarLot()
        {
            Cars.Add(new Car("Nikolair ", "Model S ", 2017, 5000));
            Cars.Add(new Car("Ford ", "Escapade ", 2018, 6000));
            Cars.Add(new Car("Nissan ", "Skyline ", 2007, 7000));
            Cars.Add(new UsedCar("GC ", "Chirpus ", 2015, 8000, 350000));
            Cars.Add(new UsedCar("GC ", "Witherell ", 2014, 9500, 340000));
            Cars.Add(new UsedCar("Lexus ", "Sclass ", 2013, 10000, 360000));

        }

        public void PrintCars()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"{i} : {Cars[i]}");
            }
        }

        public bool CarLotMenu()
        {
            //Adding Cars to List: 
           

            Console.WriteLine("Welcome to Grant Chirpus' Used Car Emproium!\n");
            Console.WriteLine("What woould you like to do 1. Add car 2. View Cars 3. Quit");

            //string userSelection = Console.ReadLine();
            //switch (userSelection)
            //{
            //    case "1": 

            //Console.Write("\nEnter the make you would like to add: ");
            //string make = Console.ReadLine();
            //Console.Write("\nEnter model: ");
            //string model = Console.ReadLine();
            //Console.Write("\nEnter the year: ");
            //int year = int.Parse(Console.ReadLine());
            //Console.Write("\nEnter Price of Car: ");
            //decimal price = Convert.ToDecimal(Console.ReadLine());
            //List<string> carItem = new List<string>();

            //        for(int i = 0; i < year; i++)
            //        {

            //        }

            Console.WriteLine("WELCOME TO THE GC USED CAR EMPORIUM!");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("[1] Add a car");
            Console.WriteLine("[2] Remove a car");
            Console.WriteLine("[3] List all availabe cars");
            Console.WriteLine("[4] Quit");
            string userMenuChoice = GetUserInput("Selection: ");
            Console.WriteLine();

                //bool userMenuChoice = true;

                switch (userMenuChoice)
                {
                    case "1":
                        //Call add car method
                        AddCar();
                        Console.WriteLine();
                        return CarLotMenu();

                    case "2":
                        //Call remove car method
                        RemoveCar();
                        Console.WriteLine();
                        return CarLotMenu();

                    case "3":
                        //Call List  all cars
                        PrintCars();
                        Console.WriteLine();
                        return CarLotMenu();


                    case "4":
                        //Will take you to y/n option to continue or quit
                        Console.WriteLine("Return to main [y] or [n]");
                        string userChoiceToReturn = Console.ReadLine().ToLower();

                        if (userChoiceToReturn == "n")
                        {
                            
                            Console.WriteLine("Thanks, Bye!");
                           
                        }
                    return CarLotMenu();


                default:
                    Console.WriteLine("That selection was invalid. Please try again.");
                    return CarLotMenu();


                    //Cars.Add(new Car(model, make, year, price));




            }


        }






        public void RemoveCar()
        {

            //Removing Car from List 

            Console.Write("Enter the make of the car you would like to remove: ");
            string make = Console.ReadLine().ToLower();
            Console.Write("Enter model: ");
            string model = Console.ReadLine().ToLower();
            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine().ToLower());
            Console.Write("Enter Price of the Car: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Cars.Remove(new Car(make, model, year, price));
        }

        public void AddCar()
        {
            Console.Write("\nEnter the make you would like to add: ");
            string make = Console.ReadLine();
            Console.Write("\nEnter model: ");
            string model = Console.ReadLine();
            Console.Write("\nEnter the year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Price of Car: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());

            Cars.Add(new Car(make, model, year, price));

        }

        public string GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine().Trim().ToLower();
            Console.WriteLine();


            return output;
        }


    }
}
    
