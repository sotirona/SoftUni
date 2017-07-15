using _05.MordorsCrueltyPlan.FoodModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MordorsCrueltyPlan
{
   public class MordorsCrueltyPlan
    {
        public static void Main()
        {
            FoodFactory foodF = new FoodFactory();

            var foodInput = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.ToLower())
                .ToList();

            List<Food> foods = foodInput.Select(x => foodF.CreateFood(x)).ToList();

            Gandalf gandalf = new Gandalf(foods);

            Console.WriteLine(gandalf);
        }
    }
}
