using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageofDoubles
{
    class AverageofDoubles
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Console.ReadLine().Split().Select(double.Parse).Average():F2}");
        }
    }
}
