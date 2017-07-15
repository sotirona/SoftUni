using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double Distance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.Distance = 0;
        }

        public void Drive(double km)
        {
            var maxDistance = this.FuelAmount / this.FuelConsumption;

            if (maxDistance < km)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.Distance += km;
                this.FuelAmount -= this.FuelConsumption * km;

            }
        }
    }
}
