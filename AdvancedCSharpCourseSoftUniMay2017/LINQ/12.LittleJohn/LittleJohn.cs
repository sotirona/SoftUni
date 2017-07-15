using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _12.LittleJohn
{
    class LittleJohn
    {
        static void Main(string[] args)
        {

            int smallArrowsCount = 0;
            int mediumArrowsCount = 0;
            int largeArrowsCount = 0;


            for (int i = 0; i < 4; i++)
            {
                var input = Console.ReadLine();

                Regex regex = new Regex(@">{3}-{5}>{2}|>{2}-{5}>|>-{5}>");

                var matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    if (match.Length == 7)
                    {
                        smallArrowsCount++;
                    }

                    if (match.Length == 8)
                    {
                        mediumArrowsCount++;
                    }
                    if (match.Length == 10)
                    {
                        largeArrowsCount++;
                    }
                }
                
            }
            var sb = new StringBuilder();
            sb.Append(smallArrowsCount.ToString() + mediumArrowsCount.ToString() + largeArrowsCount.ToString());

            var decNum = long.Parse(sb.ToString());
            var binNum = Convert.ToString(decNum, 2);

            var sb2 = new StringBuilder();

            for (int i = binNum.Length-1; i >=0 ; i--)
            {
                sb2.Append(binNum[i]);
            }

            var newBinNum = binNum+ sb2.ToString();

            var result = Convert.ToInt32(newBinNum, 2).ToString();

            Console.WriteLine(result);

        }
    }
}
