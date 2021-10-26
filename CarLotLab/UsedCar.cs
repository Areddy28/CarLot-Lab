using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotLab
{
    class UsedCar : Car
    {
        public double Mileage { get; set; }
        public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) : base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }

        public override string ToString()
        {
            string output = $"Make : {Make}\t";
            output += $"Model : {Model} \t";
            output += $"Year : {Year}";
            output += $"Price : {Price} \t";
            output += $"Mileage : {Mileage} \t"; 

            return output; 
        }


    }

}

