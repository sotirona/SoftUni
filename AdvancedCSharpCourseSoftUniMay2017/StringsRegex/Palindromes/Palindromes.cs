using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            
            List<string> palindromes = new List<string>();

            foreach (var item in array)
            {
                
                if (item.SequenceEqual(item.Reverse()))
                    
                {
                    palindromes.Add(item);
                }
            }
            
            Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(x=>x)));
        }
    }
}
