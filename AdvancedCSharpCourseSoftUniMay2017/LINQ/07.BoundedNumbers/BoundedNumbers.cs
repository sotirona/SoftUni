using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BoundedNumbers
{
    class BoundedNumbers
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine().Split().Select(long.Parse).ToList();
            Console.ReadLine().Split().Select(long.Parse).Where(x => x <= bounds.Max() && x >= bounds.Min()).ToList().ForEach(x => Console.Write(x + " "));
        }
    }
}
