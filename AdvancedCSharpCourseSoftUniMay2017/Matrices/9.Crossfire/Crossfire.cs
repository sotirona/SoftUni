using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Crossfire
{
    class Crossfire
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            List<List<int>> matrix = new List<List<int>>();
            int count = 1;

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix.Add(new List<int>());
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    matrix[rowIndex].Add(count);
                    count++;
                }
            }

            string input =Console.ReadLine();

            while (input!= "Nuke it from orbit")
            {
                int[] targetCoordinates = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                matrix = DestroyMatrixCells(matrix, targetCoordinates);

                input = Console.ReadLine();
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

        }

        private static List<List<int>> DestroyMatrixCells(List<List<int>> matrix, int[] targetCoordinates)
        {
            int targetRow = targetCoordinates[0];
            int targetCol = targetCoordinates[1];
            int radius = targetCoordinates[2];
            bool containsDestroyedCells = false;

            // update horizontal cells

            if (targetRow >= 0 && targetRow < matrix.Count)
            {
                for (int col = Math.Max(0, targetCol - radius); col <= Math.Min(targetCol + radius, matrix[targetRow].Count - 1); col++)
                {
                    matrix[targetRow][col] = 0;
                    containsDestroyedCells = true;
                }
            }

            //update vertical cells

            if (targetCol >= 0)
            {
                for (int row = Math.Max(0, targetRow - radius); row <= Math.Min(targetRow + radius, matrix.Count - 1); row++)
                {
                    if (targetCol < matrix[row].Count)
                    {
                        matrix[row][targetCol] = 0;
                        containsDestroyedCells = true;
                    }
                }
            }
            
            // remove destroyed matrix cells
            if (containsDestroyedCells)
            {
                for (int row = 0; row < matrix.Count; row++)
                {
                    if (matrix[row].Contains(0))
                    {
                        List<int> elements = new List<int>();
                        for (int col = 0; col < matrix[row].Count; col++)
                            if (matrix[row][col] != 0)
                                elements.Add(matrix[row][col]);
                        if (elements.Count > 0)
                            matrix[row] = elements;
                        else
                        {
                            matrix.RemoveAt(row);
                            row--;
                        }
                    }
                }
            }
            return matrix;

        }
    }
}
