using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.RubiksMatrix
{
    public class RubiksMatrix
    {
        public static void Main()
        {
            var rowsAndCols = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            var matrix = new int[rows][];
            int count = 1;
            
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                 matrix[rowIndex] = new int[cols];
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    matrix[rowIndex][colIndex] = count;
                    count++;
                }
            }

            int commandsNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNum; i++)
            {
                var commandsArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int index = int.Parse(commandsArgs[0]);
                string direction = commandsArgs[1];
                int moves = int.Parse(commandsArgs[2]);

                switch (direction)
                {
                    case "up":
                        MoveCol(matrix, index, moves);
                        break;
                    case "down":
                        MoveCol(matrix, index, rows - moves % rows);
                        break;
                    case "left":
                        MoveRow(matrix, index, moves);
                        break;
                    case "right":
                        MoveRow(matrix, index, cols - moves % cols);
                        break;
                }

                var element = 1;

                for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix[0].Length; colIndex++)
                    {
                        if (matrix[rowIndex][colIndex] == element)
                        {
                            Console.WriteLine("No swap required");
                        }
                        else
                        {
                            for (int r = 0; r < matrix.Length; r++)
                            {
                                for (int c = 0; c < matrix[0].Length; c++)
                                {
                                    if (matrix[r][c] == element)
                                    {
                                        var currentElement = matrix[rowIndex][colIndex];
                                        matrix[rowIndex][colIndex] = element;
                                        matrix[r][c] = currentElement;
                                        Console.WriteLine($"Swap ({rowIndex}, {colIndex}) with ({r}, {c})");
                                        break;
                                    }
                                }
                            }
                        }

                        element++;
                    }
                }
            }
        }

        private static void MoveRow(int[][] matrix, int index, int moves)
        {
            var temp = new int[matrix[0].Length];

            for (int colIndex = 0; colIndex < matrix[0].Length; colIndex++)
            {
                temp[colIndex] = matrix[index][(colIndex + moves) % matrix[0].Length];
            }

            matrix[index] = temp;

        }

        private static void MoveCol(int[][] matrix, int index, int moves)
        {
            var temp = new int[matrix.Length];

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                temp[rowIndex] = matrix[(rowIndex + moves) % matrix.Length][index];
            }

            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex][index] = temp[rowIndex];
            }
        }
    }
}
