using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\b[a-zA-Z][a-zA-Z0-9_]{2,24}\b";
            Regex regex = new Regex(pattern);
            MatchCollection matchCollection = regex.Matches(text);
            var list = new List<string>();

            int sum = 0;
            int maxSum = 0;
            string first = "";
            string second = "";


            for (int i = 1; i < matchCollection.Count; i++)
            {
                sum = matchCollection[i - 1].Length+ matchCollection[i].Length;

                if (sum>maxSum)
                {
                    maxSum = sum;
                    first = matchCollection[i - 1].ToString();
                    second = matchCollection[i].ToString();
                    
                }
            }

            Console.WriteLine(first);
            Console.WriteLine(second);

           
        }
    }
}
