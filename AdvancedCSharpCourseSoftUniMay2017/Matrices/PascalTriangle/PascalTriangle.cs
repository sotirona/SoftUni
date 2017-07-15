using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {

            long height = long.Parse(Console.ReadLine());

            long[][] triangle = new long[height][];

            for (int row = 0; row < height; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;
                triangle[row][triangle[row].Length - 1] = 1;

                for (int col = 1; col <triangle[row].Length-1; col++)
                {
                    triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                }
            }

            foreach (var row in triangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }

           
        }
    }
}
