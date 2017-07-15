using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    public class Dog : Animal
    {
        public Dog(string name, int age, string gender)
        : base(name, age, gender)
        {
        }

        public override string GetAnimalSound()
        {
            return "BauBau";
        }

        public override string ToString()
        {
            return String.Format($"Dog{Environment.NewLine}{base.ToString()}{Environment.NewLine}{GetAnimalSound()}");
        }
    }
}
