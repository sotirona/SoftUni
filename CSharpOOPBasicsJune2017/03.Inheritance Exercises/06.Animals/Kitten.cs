using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Animals
{
    public class Kitten :Cat
    {
        public Kitten(string name, int age)
       : base(name, age, "Female")
        {
        }

        public override string GetAnimalSound()
        {
            return "Miau";
        }

        public override string ToString()
        {
            return String.Format($"Kitten{Environment.NewLine}{base.ToString()}{Environment.NewLine}{GetAnimalSound()}");
        }
    }
}
