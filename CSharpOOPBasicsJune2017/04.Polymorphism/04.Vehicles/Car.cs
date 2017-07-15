using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vehicles
{
    public class Car : Vehicle
    {
        private const double AcConsumptionMod = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionPerKm) 
            : base(fuelQuantity, fuelConsumptionPerKm+ AcConsumptionMod )
        {
        }
    }
}
