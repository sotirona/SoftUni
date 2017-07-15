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

        public Truck(double fuelQuantity, double fuelConsumptionPerKm) 
            : base(fuelQuantity, fuelConsumptionPerKm + AcConsumptionMod)
        {
        }
        public override void Refuel(double fuelAmount)
        {
            this.FuelQuantity += fuelAmount*0.95;
        }
    }
}
