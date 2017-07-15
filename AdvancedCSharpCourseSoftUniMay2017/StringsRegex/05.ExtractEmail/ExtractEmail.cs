using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _05.ExtractEmail
{
    class ExtractEmail
    {
        static void Main(string[] args)
        {
            var textItems = Console.ReadLine();
            
            var regex = new Regex(@"\b(?<!\S)[a-z][a-z0-9\.\-_]+[a-z0-9]*@[a-z][a-z\-]+\.[a-z][a-z\.]+[a-z]?\b");
            var matches = regex.Matches(textItems);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }

        }
    }
}
