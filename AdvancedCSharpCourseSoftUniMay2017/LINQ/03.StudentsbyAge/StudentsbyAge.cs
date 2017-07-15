using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StudentsbyAge
{
    class StudentsbyAge
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
           
            foreach (var item in list.Where(x=> int.Parse(x[2])>=18 && int.Parse(x[2]) <= 24))
            {
                Console.WriteLine(item[0] + " " + item[1] + " " + item[2]);
            }
        }
    }
}
