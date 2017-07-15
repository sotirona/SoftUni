using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Vehicles
{
   public class StartUp
    {
        public static void Main()
        {
            var carInfo = Console.ReadLine().Split();

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

            var truckInfo = Console.ReadLine().Split();

            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var commandArgs = Console.ReadLine().Split();
                var vehicleType = commandArgs[1];

                if (vehicleType=="Car")
                {
                    ExecuteAction(car, commandArgs[0], double.Parse(commandArgs[2]));
                }
                else
                {
                    ExecuteAction(truck, commandArgs[0], double.Parse(commandArgs[2]));
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);

        }

        private static void ExecuteAction(Vehicle vehicle, string command, double parameter)
        {
            switch (command)
            {
                case "Drive":
                    var result = vehicle.TryTravelDistance(parameter);
                    Console.WriteLine(result);
                    break;
                case "Refuel":
                    vehicle.Refuel(parameter);
                    break;
            }
        }
    }
}
