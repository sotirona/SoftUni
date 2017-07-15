using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] str = Console.ReadLine().ToCharArray();

            char[] reversedStr = str.Reverse().ToArray();

            Console.WriteLine(reversedStr);
        }
    }
}
