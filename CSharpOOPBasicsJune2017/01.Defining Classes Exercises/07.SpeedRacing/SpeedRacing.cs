using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SpeedRacing
{
    public class SpeedRacing
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var currentCar = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));

                cars.Add(currentCar);
            }

            var commands = Console.ReadLine();

            while (commands!="End")
            {
                var commandsArgs = commands.Split();

                var wantedModel = commandsArgs[1];
                var distanceToTravel = double.Parse(commandsArgs[2]);

                var wantedCar = cars.Where(x => x.Model == wantedModel).FirstOrDefault();

                wantedCar.Drive(distanceToTravel);

                commands = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.Distance}");
            }
        }
    }
}
