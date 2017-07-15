using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.ExtractQuotations
{
    class ExtractQuotations
    {
        static void Main(string[] args)
        {
            
            string text = Console.ReadLine();
            Regex regex = new Regex("(\"|')(.*?)(\"|')");

            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
          
        }
    }
}
