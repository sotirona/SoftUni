using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    public class Frog : Animal
    {
        public Frog(string name, int age, string gender)
        : base(name, age, gender)
        {
        }

        public override string GetAnimalSound()
        {
            return "Frogggg";
        }

        public override string ToString()
        {
            return String.Format($"Frog{Environment.NewLine}{base.ToString()}{Environment.NewLine}{GetAnimalSound()}");
        }
    }
}
