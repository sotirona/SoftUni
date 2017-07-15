using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RawData
{
    public class RawData
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var carList = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                var cargo = new Cargo(int.Parse(input[3]), input[4]);

                var tires = new Tire[]
                {
                    new Tire(int.Parse(input[6]), double.Parse(input[5])),
                    new Tire(int.Parse(input[8]), double.Parse(input[7])),
                    new Tire(int.Parse(input[10]), double.Parse(input[9])),
                    new Tire(int.Parse(input[12]), double.Parse(input[11])),
                };

                var currentCar = new Car(input[0], engine, cargo, tires);

                carList.Add(currentCar);
            }
            
            var command = Console.ReadLine();

            if (command== "fragile")
            {   
                foreach (var car in carList.Where(c => c.CarCargo.Type==command).Where(t=> t.Tires.Any(x=>x.Pressure<1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in carList.Where(c => c.CarCargo.Type == command).Where(t => t.Engine.Power>250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
