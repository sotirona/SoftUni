using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.ValidTime
{
    class ValidTime
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();

            while (time!="END")
            {
                Regex regex = new Regex(@"^([01]{1}[0-9]{1}:[012345]{1}[0-9]{1}:[012345]{1}[0-9]{1} [AP]M)$");

                if (regex.IsMatch(time))
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                time = Console.ReadLine();

               
            }
        }
    }
}
