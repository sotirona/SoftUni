using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.GroupbyGroup
{
    public class GroupbyGroup
    {
        public class Person
        {
            public string Name { get; set; }
            public int Group { get; set; }
        }
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<Person>();

            while (input != "END")
            {
                var inputArgs = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentPerson = new Person
                {
                    Name = $"{inputArgs[0]}" + " " + $"{inputArgs[1]}",
                    Group = int.Parse(inputArgs[2])
                };

                list.Add(currentPerson);

                input = Console.ReadLine();
            }
            
            foreach (var item in list.GroupBy(x=>x.Group, x=>x.Name).OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item)} ");
            }
        }
    }
}
