using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vehicles
{
    public abstract class Vehicle
    {

        public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionPerKm = fuelConsumptionPerKm;           
        }

        protected virtual double FuelQuantity { get; set; }
        protected double FuelConsumptionPerKm { get; set; }
        protected virtual double TankCapacity { get; set; }

        protected virtual bool Drive(double distance, bool IsAcOn)
        {
            var fuelRequired = distance * this.FuelConsumptionPerKm;

            if (fuelRequired<=this.FuelQuantity)
            {
                this.FuelQuantity -= fuelRequired; 
                return true;
            }
            else
            {
                return false;
            }
        }

        public string TryTravelDistance(double distance, bool IsAcOn)
        {
            if (this.Drive(distance, IsAcOn))
            {
                return $"{this.GetType().Name} travelled {distance} km";
            }

            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public string TryTravelDistance(double distance)
        {
           return this.TryTravelDistance(distance, true);
        }

        public virtual void Refuel(double fuelAmount)
        {
            if (fuelAmount<=0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            this.FuelQuantity += fuelAmount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }
    }
}
