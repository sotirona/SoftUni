using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.LegoBlocks
{
    class LegoBlocks
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var firstJaggedarray = new int[n][];
            var secondJaggedarray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                firstJaggedarray[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            for (int i = 0; i < n; i++)
            {
                secondJaggedarray[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
                        
            for (int i = 0; i < n; i++)
            {
              Array.Reverse(secondJaggedarray[i]);
            }

            var newJaggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                newJaggedArray[i] = firstJaggedarray[i].Concat(secondJaggedarray[i]).ToArray();
                
            }

            bool isEqual = true;
            int totalCells = 0;

            for (int i = 0; i < n-1; i++)
            {
                if (newJaggedArray[i].Length != newJaggedArray[i+1].Length)
                {
                    isEqual = false;
                    break;
                   
                }

            }
            
            for (int i = 0; i < n; i++)
            {
                totalCells += newJaggedArray[i].Length;
            }

            if (isEqual)
            {
                foreach (var row in newJaggedArray)
                {
                    Console.WriteLine($"[{string.Join(", ", row)}]");
                }
            }
            
            else
            {
                Console.WriteLine($"The total number of cells is: {totalCells}");
            }
          
        }
    }
}
