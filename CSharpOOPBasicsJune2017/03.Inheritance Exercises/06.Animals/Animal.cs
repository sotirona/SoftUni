using System;
using System.Text;

namespace _06.Animals
{
    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Gender
        {
            get { return gender; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()) || value < 0) // watch for this checker
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        public virtual string GetAnimalSound()
        {
            return "";
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append($"{this.Name} {this.Age} {this.Gender}");

            return stringBuilder.ToString();
        }
    }
}
