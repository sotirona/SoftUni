using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MinEvenNumber
{
    class MinEvenNumber
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"{Console.ReadLine().Split().Select(double.Parse).Where(x => x % 2 == 0).ToList().Min():F2}");
            }
            catch (Exception)
            {
                Console.WriteLine("No match");
            }
           
            
        }
    }
}
