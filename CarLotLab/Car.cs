using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotLab
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set;}

        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;  
        }

       

        public override string ToString()
        {
            string output = $"Make : {Make}\t\t";
            output += $" Model : {Model}\t\t";
            output += $" Year : {Year}";
            output += $" Price : {Price}\t\t";

            return output;

            //return String.Format($"{0, -10} | {1, -15} | {2, -5} | {3, -15: C2} | { Make} { Model} { Year} { Price}"); 
        }
    }
}
