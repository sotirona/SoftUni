using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender)
        : base(name, age, gender)
        {
        }

        public override string GetAnimalSound()
        {
            return "MiauMiau";
        }

        public override string ToString()
        {
            return String.Format($"Cat{Environment.NewLine}{base.ToString()}{Environment.NewLine}{GetAnimalSound()}");
        }
    }
}
