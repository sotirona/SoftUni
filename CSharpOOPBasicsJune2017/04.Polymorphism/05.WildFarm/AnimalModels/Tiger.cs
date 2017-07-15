using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WildFarm.Models
{
    public class Tiger : Feline
    {
        public Tiger(string animalName, string animalType, double animalWeight, string livingRegion)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override string MakeSound()
        {
            return "ROAAR!!!";
        }

        public override void Eat(string foodType, int quantity)
        {
            if (foodType != "Meat")
            {
                throw new ArgumentException("Tigers are not eating that type of food!");
            }

            this.FoodEaten += quantity;
        }

       
    }
}
