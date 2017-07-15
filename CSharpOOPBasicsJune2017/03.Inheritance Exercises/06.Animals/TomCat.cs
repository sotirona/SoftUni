using System;


namespace _06.Animals
{
    public class TomCat : Cat
    {
        public TomCat(string name, int age)
            :base(name, age, "Male")
        {
        }

        public override string GetAnimalSound()
        {
            return "Give me one million b***h";
        }

        public override string ToString()
        {
            return String.Format($"Tomcat{Environment.NewLine}{base.ToString()}{Environment.NewLine}{GetAnimalSound()}");
        }
    }
}
