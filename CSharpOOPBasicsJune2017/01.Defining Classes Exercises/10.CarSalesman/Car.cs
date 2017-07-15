using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CarSalesman
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public string Weight { get; set; }
        public string Color { get; set; }
        
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }

        public override string ToString()
        {
            return String.Format($"{this.Model}:\r\n  {this.Engine.Model}:\r\n    Power: {this.Engine.Power}\r\n    Displacement: {this.Engine.Displacement}\r\n    Efficiency: {this.Engine.Efficiency}\r\n  Weight: {this.Weight}\r\n  Color: {this.Color}");
        }
    }
}
