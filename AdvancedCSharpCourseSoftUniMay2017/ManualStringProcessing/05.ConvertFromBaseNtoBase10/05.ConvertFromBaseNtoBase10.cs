using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.ConvertFromBaseNtoBase10
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Trim().Split();
            int baseNNum = int.Parse(input[0]);
            char[] baseTenNum = input[1].ToCharArray();

            BigInteger result = new BigInteger(0);

            for (int i = 0; i < baseTenNum.Length; i++)
            {
                int currentNum = (int)Char.GetNumericValue(baseTenNum[i]);
                result += currentNum * BigInteger.Pow(baseNNum, baseTenNum.Length - i - 1);
            }

            Console.WriteLine(result);
            
        }
    }
}
