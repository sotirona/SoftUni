using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.StudentsEnrolledin2014or2015
{
    class StudentsEnrolledin2014or2015
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var list = new List<string[]>();

            while (input != "END")
            {
                list.Add(input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                input = Console.ReadLine();
            }

            foreach (var item in list.Where(x => x[0].EndsWith("14") || x[0].EndsWith("15")))
            {
                
                Console.WriteLine(string.Join(" ", item.Skip(1)));
            }
        }
    }
}
