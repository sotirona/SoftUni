using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacters
{
    public class UnicodeCharacters
    {
       public static void Main()
        {
            var chars = Console.ReadLine().Select(c => (int)c).Select(c => $@"\u{c:x4}"); ;
            
            var result = string.Concat(chars);

            Console.WriteLine(result);
        }
    }
}
