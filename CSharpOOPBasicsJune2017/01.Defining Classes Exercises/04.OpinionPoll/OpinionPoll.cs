using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.OpinionPoll
{
    public class OpinionPoll
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var people = new List<Person>();
            
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var personName = input[0];
                var personAge = int.Parse(input[1]);

                var currentPerson = new Person(personName, personAge);
                people.Add(currentPerson);
            }

            foreach (var person in people.Where(p=>p.Age>30).OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
