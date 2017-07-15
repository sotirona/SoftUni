using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = n;
            int cols = n;

            var matrix = new int[n][];

            for (int rowIndex = 0; rowIndex < n; rowIndex++)
            {
                var matrixArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                matrix[rowIndex] = matrixArgs;
            }

            int firstDiagonal = 0;
            int secondDiagonal = 0;


            for (int i = 0; i < n; i++)
            {
                firstDiagonal += matrix[i][i];
                
            }

            for (int i = n-1; i >= 0; i--)
            {
                secondDiagonal += matrix[n-i-1][i];
            }

            int difference = Math.Abs(firstDiagonal - secondDiagonal);

            Console.WriteLine(difference);
        }
    }
}
