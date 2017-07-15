using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ExcellentStudents
{
    class ExcellentStudents
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

            foreach (var item in list.Where(x=> x.Any(y=> y=="6")))
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }
        }
    }
}
