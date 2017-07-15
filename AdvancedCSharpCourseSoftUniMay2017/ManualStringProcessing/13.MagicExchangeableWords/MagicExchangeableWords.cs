using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MagicExchangeableWords
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split();

            string firstWord = text[0];
            string secondWord = text[1];

            HashSet<char> firstSet = new HashSet<char>();
            HashSet<char> secondSet = new HashSet<char>();

            for (int i = 0; i < firstWord.Length; i++)
            {
                firstSet.Add(firstWord[i]);
            }

            for (int i = 0; i < secondWord.Length; i++)
            {
                secondSet.Add(secondWord[i]);
            }

            if (firstSet.Count==secondSet.Count)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
