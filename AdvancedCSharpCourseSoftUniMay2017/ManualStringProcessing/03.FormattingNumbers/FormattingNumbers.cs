using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FormattingNumbers
{
    public class FormattingNumbers
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', '\n','\t', '\r'}, StringSplitOptions.RemoveEmptyEntries);

            long a = long.Parse(text[0]);
            double b = double.Parse(text[1]);
            double c = double.Parse(text[2]);

            string hexNumber = a.ToString("X").PadRight(10);
            string binaryNumber = Convert.ToString(a, 2).PadLeft(10, '0').Substring(0,10);
            string bNumber = b.ToString("0.00").PadLeft(10);
            string cNumber = c.ToString("0.000").PadRight(10);

            Console.WriteLine($"|{hexNumber}|{binaryNumber}|{bNumber}|{cNumber}|");
        }
    
    }
}
