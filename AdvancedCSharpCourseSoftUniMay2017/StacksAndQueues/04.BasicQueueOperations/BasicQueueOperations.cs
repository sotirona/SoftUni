using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BasicQueueOperations
{
    public class BasicQueueOperations
    {
        public static void Main()
        {

            int[] commandArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsNumber = commandArgs[0];
            int elementsToPop = commandArgs[1];
            int presentElement = commandArgs[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < elementsNumber; i++)
            {
                stack.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Dequeue();
            }

            if (stack.Contains(presentElement))
            {
                Console.WriteLine("true");
            }

            else if (stack.Count != 0)
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
