using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MordorsCrueltyPlan.FoodModels
{
  public class Food
    {
        public Food(int happiness)
        {
            this.Happiness = happiness;
        }

        private int happiness;

        public int Happiness
        {
            get { return this.happiness; }
            set { this.happiness = value; }
        }
    }
}
