using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CalculateSequenceWithQueue
{
    class CalculateSequenceWithQueue
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Queue<long> myQueue = new Queue<long>();
            List<long> myList = new List<long>();

            myQueue.Enqueue(n);
            myList.Add(n);

            while (myQueue.Count < 50)
            {
                long currentNumber = myQueue.Dequeue();

                long firstNumber = currentNumber + 1;
                long secondNumber = currentNumber * 2 + 1;
                long thirdNumber = currentNumber + 2;

                myQueue.Enqueue(firstNumber);
                myQueue.Enqueue(secondNumber);
                myQueue.Enqueue(thirdNumber);

                myList.Add(firstNumber);
                myList.Add(secondNumber);
                myList.Add(thirdNumber);
                
            }


            for (var i = 0; i < 50; i++)
            {
                Console.Write(myList[i] + " ");
            }
        }
    }
}
