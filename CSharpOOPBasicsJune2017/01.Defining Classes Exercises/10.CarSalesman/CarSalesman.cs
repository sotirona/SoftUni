using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CarSalesman
{
    public class CarSalesman
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var engines = new List<Engine>();
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var engineArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = engineArgs[0];
                var power = double.Parse(engineArgs[1]);

                var engine = new Engine(model, power);

                if (engineArgs.Length > 2)
                {

                    double s;
                    if (double.TryParse(engineArgs[2], out s))
                    {
                        engine.Displacement = s.ToString();
                    }
                    else
                    {
                        engine.Efficiency = engineArgs[2];
                    }
                }
                if (engineArgs.Length > 3)
                {
                    engine.Efficiency = engineArgs[3];
                }

                engines.Add(engine);

            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var carArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var model = carArgs[0];
                var engineModel = carArgs[1];
                var engine = engines.Where(x => x.Model == engineModel).FirstOrDefault();

                var car = new Car(model, engine);

                if (carArgs.Length > 2)
                {

                    double s;
                    if (double.TryParse(carArgs[2], out s))
                    {
                        car.Weight = s.ToString();
                    }
                    else
                    {
                        car.Color = carArgs[2];
                    }
                }
                if (carArgs.Length > 3)
                {
                    car.Color = carArgs[3];
                }

                cars.Add(car);
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
