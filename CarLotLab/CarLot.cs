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

        public void AddCar()
        {
            //Adding Cars to List: 



            Console.Write("\nEnter the make you would like to add: ");
            string make = Console.ReadLine();
            Console.Write("\nEnter model: ");
            string model = Console.ReadLine();
            Console.Write("\nEnter the year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("\nEnter Price of Car: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());




            Cars.Add(new Car(model, make, year, price));


        }






        public void RemoveCar()
        {

            //Removing Car from List 

            Console.Write("Enter the make of the car you would like to remove: ");
            string make = Console.ReadLine();
            Console.Write("Enter model: ");
            string model = Console.ReadLine();
            Console.Write("Enter the year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter Price of the Car: ");
            int price = int.Parse(Console.ReadLine());

            Cars.Remove(new Car(model, make, year, price));
        }

    }
}
    
