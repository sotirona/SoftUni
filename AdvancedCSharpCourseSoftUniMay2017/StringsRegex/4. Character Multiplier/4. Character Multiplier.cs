using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split();
            string word1 = str[0];        
            string word2 = str[1];

            int minlen = Math.Min(word1.Length, word2.Length);
            int maxLen = Math.Max(word1.Length, word2.Length);
            string longerInput = "";            
            long sum = 0;
            
            if (word1.Length> word2.Length)
            {
                longerInput = word1;
            }

            else if(word1.Length < word2.Length)
            {
                longerInput = word2;
            }

            for (int i = 0; i < minlen; i++)
            {
                sum += word1[i] * word2[i];
            }

            for (int i = minlen; i < maxLen; i++)
            {
                sum += longerInput[i];
            }

            Console.WriteLine(sum);            
        }
    }
}
