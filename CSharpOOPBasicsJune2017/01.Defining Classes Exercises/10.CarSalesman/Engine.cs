using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CarSalesman
{
    public class Engine
    {
        public string Model { get; set; }
        public double Power { get; set; }
        public string Displacement { get; set; }
        public string Efficiency { get; set; }
        
        public Engine(string model, double power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }
    }
}
