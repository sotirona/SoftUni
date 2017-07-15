using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupNumbers
{
    class GroupNumbers
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[] sizes = new int[3];

            foreach (var num in input)
            {
                int reminder = Math.Abs(num) % 3;
                sizes[reminder]++;
            }

            int[][] matrix =
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]],
            };
            
            int[] array = new int[3];

            foreach (var num in input)
            {
                int reminder = Math.Abs(num) % 3;
                int index = array[reminder];
                matrix[reminder][index] = num;
                array[reminder]++;

            }

            Console.WriteLine(string.Join(" ", matrix[0]));
            Console.WriteLine(string.Join(" ", matrix[1]));
            Console.WriteLine(string.Join(" ", matrix[2]));
        }
    }
}
