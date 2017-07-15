using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BalancedParenthesis
{
    public class BalancedParenthesis
    {
        public static void Main()
        {
            string input = Console.ReadLine().Trim();
            char[] splittedInput = input.ToCharArray();
            int j = splittedInput.Length - 1;
            string message = "NO";

            if (splittedInput.Length <= 1 || splittedInput.Length >= 1000 || string.IsNullOrEmpty(input))
            {
                return;
            }

            if (splittedInput.Length % 2 != 0)
            {
                Console.WriteLine(message);
                return;
            }

            else
            {
                for (int i = 0; i <= (splittedInput.Length / 2) - 1; i++, j--)
                {
                    if (splittedInput[i] == '{' && splittedInput[j] != '}')
                    {
                        message = "NO";
                        break;
                    }
                    if (splittedInput[i] == '(' && splittedInput[j] != ')')
                    {
                        message = "NO";
                        break;
                    }
                    if (splittedInput[i] == '[' && splittedInput[j] != ']')
                    {
                        message = "NO";
                        break;
                    }
                    if (splittedInput[i] == '{' && splittedInput[j] == '}')
                    {
                        message = "YES";
                    }

                    if (splittedInput[i] == '(' && splittedInput[j] == ')')
                    {
                        message = "YES";
                    }

                    if (splittedInput[i] == '[' && splittedInput[i + 1] == ']')
                    {
                        message = "YES";
                    }
                   
                }
            }
            Console.WriteLine(message);
            return;

        }
    }
}
