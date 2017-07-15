
using System;

public class Program
{
    public static void Main()
    {
        var carManager = new CarManager();

        string command = String.Empty;

        while ((command = Console.ReadLine()) != "Cops Are Here")
        {
            var cmdArgs = command.Split(' ');
            int id;
            string type;
            int raceId;

            switch (cmdArgs[0])
            {
                case "register":
                    id = int.Parse(cmdArgs[1]);
                    type = cmdArgs[2];
                    string brand = cmdArgs[3];
                    string model = cmdArgs[4];
                    int yearOfProduction = int.Parse(cmdArgs[5]);
                    int horsepower = int.Parse(cmdArgs[6]);
                    int acceleration = int.Parse(cmdArgs[7]);
                    int suspension = int.Parse(cmdArgs[8]);
                    int durability = int.Parse(cmdArgs[9]);
                    carManager.Register(id, type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                    break;
                case "check":
                    Console.WriteLine(carManager.Check(int.Parse(cmdArgs[1])));
                    break;
                case "open":
                    id = int.Parse(cmdArgs[1]);
                    type = cmdArgs[2];
                    int lenght = int.Parse(cmdArgs[3]);
                    string route = cmdArgs[4];
                    int pricePool = int.Parse(cmdArgs[5]);
                    carManager.Open(id, type, lenght, route, pricePool);
                    break;
                case "participate":
                    int carId = int.Parse(cmdArgs[1]);
                    raceId = int.Parse(cmdArgs[2]);
                    carManager.Participate(carId, raceId);
                    break;
                case "start":
                    raceId = int.Parse(cmdArgs[1]);
                    Console.WriteLine(carManager.Start(raceId));
                    break;
                case "park":
                    id = int.Parse(cmdArgs[1]);
                    carManager.Park(id);
                    break;
                case "unpark":
                    id = int.Parse(cmdArgs[1]);
                    carManager.Unpark(id);
                    break;
                case "tune":
                    int tuneIndex = int.Parse(cmdArgs[1]);
                    string addon = cmdArgs[2];
                    carManager.Tune(tuneIndex, addon);
                    break;

            }
        }

    }
}


