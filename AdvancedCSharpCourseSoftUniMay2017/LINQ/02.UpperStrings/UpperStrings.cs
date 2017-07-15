using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.UpperStrings
{
    class UpperStrings
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split().Select(x => x.ToUpper()).ToList().ForEach(x => Console.Write(x+ " "));
        }
    }
}
