using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CountSubstringOccurrences
{
    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();

            int counter = 0;
            int index = input.IndexOf(pattern);

            while (index != -1)
            {
                counter++;
                index = input.IndexOf(pattern, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
