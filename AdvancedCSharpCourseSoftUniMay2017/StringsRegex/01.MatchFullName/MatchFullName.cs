using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"^[A-Z]{1}[a-z]+\s[A-Z][a-z]+");

            while (text != "end")
            {
                Match matches = regex.Match(text);
                Console.WriteLine(matches.Value);

                text = Console.ReadLine();
            }
        }
    }
}
