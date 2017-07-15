using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.CharacterMultiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string firstWord = text[0];
            string secondWord = text[1];

            int minLength = Math.Min(firstWord.Length, secondWord.Length);
            int maxLength = Math.Max(firstWord.Length, secondWord.Length);

            long sum = 0;

            if (firstWord.Length == secondWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += (int)firstWord[i] * (int)secondWord[i];
                }
            }

            else
            {

                string longerWord = String.Empty;

                if (firstWord.Length > secondWord.Length)
                {
                    longerWord = firstWord;
                }
                else
                {
                    longerWord = secondWord;
                }
                for (int i = 0; i < minLength; i++)
                {
                    sum += (int)firstWord[i] * (int)secondWord[i];
                }

                for (int i = minLength; i < maxLength; i++)
                {
                    sum += (int)longerWord[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
