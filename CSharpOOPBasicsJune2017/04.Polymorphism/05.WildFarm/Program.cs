using _05.WildFarm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WildFarm
{
    public class Program
    {
        public static void Main()
        {
            var animalInfo = Console.ReadLine();

            while (animalInfo!="End")
            {
                var foodArgs = Console.ReadLine().Split();

                var animalArgs = animalInfo.Split();

                Animal currentAnimal = GenerateSpecificAnimal(animalArgs);
              
                var foodType = foodArgs[0];
                var foodQuantity = int.Parse(foodArgs[1]);
                Console.WriteLine(currentAnimal.MakeSound());
                try
                {
                    currentAnimal.Eat(foodType, foodQuantity);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                Console.WriteLine(currentAnimal);
                animalInfo = Console.ReadLine();
            }
        }

        private static Animal GenerateSpecificAnimal(string[] animalArgs)
        {
            switch (animalArgs[0])
            {
                case "Cat":
                    return new Cat(animalArgs[1], animalArgs[0], double.Parse(animalArgs[2]), animalArgs[3], animalArgs[4]);
                case "Tiger":
                    return new Tiger(animalArgs[1], animalArgs[0], double.Parse(animalArgs[2]), animalArgs[3]);
                case "Zebra":
                    return new Zebra(animalArgs[1], animalArgs[0], double.Parse(animalArgs[2]), animalArgs[3]);
                case "Mouse":
                    return new Mouse(animalArgs[1], animalArgs[0], double.Parse(animalArgs[2]), animalArgs[3]);
                default:
                    return null;

            }
        }
    }
}
