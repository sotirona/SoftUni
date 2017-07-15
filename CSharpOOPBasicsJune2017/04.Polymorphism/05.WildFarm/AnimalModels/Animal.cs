using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WildFarm
{
   public abstract class Animal
    {
        private string animalName;
        private string animalType;
        private double animalWeight;
        private int foodEaten;

        public Animal(string animalName, string animalType, double animalWeight)
        {
            this.AnimalName = animalName;
            this.animalType = animalType;
            this.AnimalWeight = animalWeight;
            this.FoodEaten = foodEaten;

        }
        public string AnimalName
        {
            get { return this.animalName; }
            set { this.animalName = value; }
        }

        public string AnimalType
        {
            get { return this.animalType; }
            set { this.animalType = value; }
        }
        
        public double AnimalWeight
        {
            get { return this.animalWeight; }
            set { this.animalWeight = value; }
        }
        
        public int FoodEaten
        {
            get { return this.foodEaten; }
            set { this.foodEaten = value; }
        }
        
        public virtual void Eat(string type, int quantity)
        {
            this.FoodEaten += quantity;
        }
        public abstract string MakeSound();

    }
}
