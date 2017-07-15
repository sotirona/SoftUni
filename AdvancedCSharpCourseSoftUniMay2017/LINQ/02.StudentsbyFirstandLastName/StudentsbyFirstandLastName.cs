using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsbyFirstandLastName
{
    class StudentsbyFirstandLastName
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

            foreach (var item in list.Where(x => x[0].CompareTo(x[1])==-1))
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }
        }
    }
}
