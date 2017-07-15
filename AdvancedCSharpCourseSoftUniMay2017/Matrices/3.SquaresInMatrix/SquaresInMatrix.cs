using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SquaresInMatrix
{
    class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            var matrix = new char[rows][];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                var matrixArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                matrix[rowIndex] = matrixArgs;
            }


            int count = 0;
            bool isSquare = false;

            for (int rowIndex = 0; rowIndex < rows-1; rowIndex++)
            {
                for (int colIndex = 0; colIndex < cols-1; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] == matrix[rowIndex][colIndex + 1] && matrix[rowIndex][colIndex] == matrix[rowIndex + 1][colIndex] &&matrix[rowIndex + 1][colIndex] == matrix[rowIndex + 1][colIndex + 1])
                    {
                        count++;
                        isSquare = true;
                    }
                }
            }

            if (isSquare)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(0);
            }
            
        }
    }
}
