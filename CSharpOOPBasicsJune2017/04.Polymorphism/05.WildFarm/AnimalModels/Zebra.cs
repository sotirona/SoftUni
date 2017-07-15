﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.WildFarm
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, string livingRegion) 
            : base(animalName, animalType, animalWeight, livingRegion)
        {
        }

        public override void Eat(string foodType, int quantity)
        {
            if (foodType != "Vegetable")
            {
                throw new ArgumentException("Zebras are not eating that type of food!");
            }

            this.FoodEaten += quantity;
        }

        public override string MakeSound()
        {
            return "Zs";
        }

        
    }
}
