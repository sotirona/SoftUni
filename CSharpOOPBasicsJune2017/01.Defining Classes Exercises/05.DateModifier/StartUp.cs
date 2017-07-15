using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DateModifier
{
    public class StartUp
    {
        public static void Main()
        {
            var dateOne = Console.ReadLine();
            var dateTwo = Console.ReadLine();

            Console.WriteLine(DateModifier.GetDateDifference(dateOne, dateTwo));
        }
    }
}
