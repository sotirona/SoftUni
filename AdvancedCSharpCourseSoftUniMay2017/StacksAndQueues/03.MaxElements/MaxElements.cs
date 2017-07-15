using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaxElements
{
    public class MaxElements
    {
        public static void Main()
        {

            Stack<int> myStack = new Stack<int>();
            Stack<int> maxNumbers = new Stack<int>();
            int maxElement = int.MinValue;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();
                string command = commandArgs[0];

                if (command == "1")
                {
                    int numberToPush = int.Parse(commandArgs[1]);
                    myStack.Push(numberToPush);

                    if (numberToPush > maxElement)
                    {
                        maxElement = numberToPush;
                        maxNumbers.Push(maxElement);
                    }
                }

                else if (command == "2")
                {
                    int currentNumber = myStack.Pop();
                 
                    if (maxNumbers.Count > 0 && currentNumber == maxNumbers.Peek())
                    {
                        maxNumbers.Pop();
                    }
                    else
                    {
                        maxElement = int.MinValue;
                    }
                }

                else
                {
                    Console.WriteLine(maxNumbers.Peek());
                }
            }
        }
    }
}
