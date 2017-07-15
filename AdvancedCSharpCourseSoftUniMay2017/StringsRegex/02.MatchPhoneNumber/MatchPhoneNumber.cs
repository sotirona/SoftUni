using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {

            var firstReg = new Regex(@"^\+359-\d-\d{3}-\d{4}$");
            var secondReg = new Regex(@"^\+359 \d \d{3} \d{4}$");

            var phone = Console.ReadLine();

            while (!phone.Equals("end"))
            {

                if (firstReg.IsMatch(phone) || secondReg.IsMatch(phone))
                {
                    Console.WriteLine(phone);
                }

                phone = Console.ReadLine();
            }
        }
    }
}
