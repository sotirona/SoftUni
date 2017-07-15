using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FindandSumIntegers
{
    class FindandSumIntegers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            long i;
            var numbers = input.Where(x => long.TryParse(x, out i)).ToList();

            if (numbers.Count == 0)
            {
                Console.WriteLine("No match");
            }
            else
            {
                var sum = numbers.Select(long.Parse).Sum();
                Console.WriteLine(sum);
            }
        }
    }
}
