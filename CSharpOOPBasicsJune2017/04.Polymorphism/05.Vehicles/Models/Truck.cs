using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vehicles
{
    public class Truck : Vehicle
    {
        private const double AcConsumptionMod = 1.6;
        private const double FuelLossfactor = 0.95;

        public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm + AcConsumptionMod, tankCapacity)
        {
        }
        public override void Refuel(double fuelAmount)
        {
            base.Refuel(fuelAmount * FuelLossfactor);
        }
    }
}
