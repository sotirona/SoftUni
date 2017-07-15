using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
            while (name!="END")
            {
                Regex regex = new Regex(@"^([0-9A-Za-z-_]{3,16}$)");

                if (regex.IsMatch(name))
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }

                name = Console.ReadLine();
            }
        }
    }
}
