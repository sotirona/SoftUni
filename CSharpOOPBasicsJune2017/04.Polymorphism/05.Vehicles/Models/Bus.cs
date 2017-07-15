using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vehicles
{
    public class Bus : Vehicle
    {
        private const double AcConsumptionMod = 1.4;
        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
        {
        }

        protected override double FuelQuantity
        {
            get
            {
                return base.FuelQuantity;
            }

            set
            {
                if (value> this.TankCapacity)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }
                base.FuelQuantity = value;
            }
        }

        protected override bool Drive(double distance, bool IsAcOn)
        {
            double requiredFuel = 0;
            if (IsAcOn)
            {
                requiredFuel = (this.FuelConsumptionPerKm + AcConsumptionMod)* distance;
            }
            else
            {
                requiredFuel = this.FuelConsumptionPerKm * distance;
            }

            if (requiredFuel<=this.FuelQuantity)
            {
                this.FuelQuantity -= requiredFuel;
                return true;
            }

            return false;
        }
    }
}
