using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Palindromes
{
    class Palindomes
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            
            foreach (var word in text)
            {
                if (word.Length==1)
                {
                    palindromes.Add(word);
                }

                else
                {
                    char[] reversedString = word.ToArray();

                    Array.Reverse(reversedString);

                    if (word == String.Concat(reversedString))
                    {
                        palindromes.Add(word);
                    }
                }                
            }

            palindromes.Sort();
            Console.WriteLine($"[{string.Join(", ", palindromes.Distinct())}]");
        }
    }
}
