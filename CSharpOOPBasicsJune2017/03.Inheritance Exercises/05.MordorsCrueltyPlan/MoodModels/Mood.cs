using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MordorsCrueltyPlan.MoodModels
{
    public abstract class Mood
    {
        public Mood(string type)
        {
            this.Type = type;
        }

        private string type;

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public override string ToString()
        {
            return $"{GetType().Name}";
        }
    }
}
