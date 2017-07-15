using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.DateModifier
{
    public class DateModifier
    {
       
        public static int GetDateDifference(string dateOne, string dateTwo)
        {
            var parsedDateOne = DateTime.ParseExact(dateOne, "yyyy MM dd", CultureInfo.InvariantCulture);
            var parsedDateTwo = DateTime.ParseExact(dateTwo, "yyyy MM dd", CultureInfo.InvariantCulture);

            var difference = Math.Abs((parsedDateOne - parsedDateTwo).Days);

            return difference;
        }
    }
}
