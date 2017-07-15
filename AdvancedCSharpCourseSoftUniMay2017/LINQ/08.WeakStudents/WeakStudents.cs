using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.WeakStudents
{
    class WeakStudents
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

            foreach (var item in list.Where(x => x.Count(y => y == "2"||y=="3")>=2))
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }
        }
    }
}
