using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WildFarm.Models
{
    public class Cat : Feline
    {
        private string breed;

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }

        public Cat(string animalName, string animalType, double animalWeight, string livingRegion, string breed)
            : base(animalName, animalType, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.AnimalType}[{this.AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]");
            return sb.ToString();
        }
    }
}
