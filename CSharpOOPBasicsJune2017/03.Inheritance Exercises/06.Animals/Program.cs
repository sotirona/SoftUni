using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
   public class Program
    {
       public static void Main()
        {

            var input = Console.ReadLine();
            var result = new StringBuilder();

            while (!input.Equals("Beast!"))
            {
                try
                {
                    string animalKind = input;
                    var animalInfo = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string name = animalInfo[0];

                    int age;
                    bool ageParse = int.TryParse(animalInfo[1], out age);
                    age = ageParse != true ? -1 : age;

                    string gender = animalInfo[2];

                    input = Console.ReadLine();

                    Animal currentAnimal = GenerateSpecificAnimal(animalKind, name, age, gender);
                    result.AppendLine(currentAnimal.ToString());
                }
                catch (ArgumentException ex)
                {
                    result.AppendLine(ex.Message);
                }
            }
            Console.WriteLine(result);
        }

        private static Animal GenerateSpecificAnimal(string animalKind, string name, int age, string gender)
        {
            switch (animalKind)
            {
                case "Cat":
                    return new Cat(name, age, gender);
                case "Dog":
                    return new Dog(name, age, gender);
                case "Frog":
                    return new Frog(name, age, gender);
                case "Kitten":
                    return new Kitten(name, age);
                case "Tomcat":
                    return new TomCat(name, age);
                default:
                    throw new ArgumentException("Invalid input!");
            }
        }
    }
}
