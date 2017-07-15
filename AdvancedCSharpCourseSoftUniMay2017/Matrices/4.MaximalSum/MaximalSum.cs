using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            var matrix = new int[rows][];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                var matrixArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                matrix[rowIndex] = matrixArgs;
            }

            long sum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int rowIndex = 0; rowIndex < rows - 2; rowIndex++)
            {
                for (int colIndex = 0; colIndex < cols - 2; colIndex++)
                {
                    long temp = matrix[rowIndex][colIndex] + matrix[rowIndex][colIndex + 1] + matrix[rowIndex][colIndex + 2] +
                                matrix[rowIndex + 1][colIndex] + matrix[rowIndex + 1][colIndex + 1] + matrix[rowIndex + 1][colIndex + 2] +
                                matrix[rowIndex + 2][colIndex] + matrix[rowIndex + 2][colIndex + 1] + matrix[rowIndex + 2][colIndex + 2];

                    if (sum < temp)
                    {
                        sum = temp;
                        bestRow = rowIndex;
                        bestCol = colIndex;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");

            Console.WriteLine($"{matrix[bestRow][bestCol]} {matrix[bestRow][bestCol + 1]} {matrix[bestRow][bestCol + 2]}");
            Console.WriteLine($"{matrix[bestRow+1][bestCol]} {matrix[bestRow+1][bestCol + 1]} {matrix[bestRow+1][bestCol + 2]}");
            Console.WriteLine($"{matrix[bestRow+2][bestCol]} {matrix[bestRow+2][bestCol + 1]} {matrix[bestRow+2][bestCol + 2]}");

        }
    }
}

