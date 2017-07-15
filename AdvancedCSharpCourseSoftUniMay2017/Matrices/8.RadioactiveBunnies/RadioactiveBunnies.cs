using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.RadioactiveBunnies
{
    class RadioactiveBunnies
    {

        static int[] playerPosition = new int[2];
        static bool gameOverWon = false;
        static bool gameOverDead = false;

        static void Main()
        {
            var sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            var matrix = new char[rows][];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = Console.ReadLine().ToArray();
            }


            var commands = Console.ReadLine().ToArray();


            while (!gameOverDead && !gameOverWon)
            {
                foreach (var command in commands)
                {
                    UpdatePlayer(matrix, command);
                    UpdateBunnies(matrix);
                    if (gameOverWon || gameOverDead)
                    {
                        break;
                    }
                }

                
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }

            if (gameOverWon)
            {
                Console.WriteLine($"won: {string.Join(" ", playerPosition)}");
            }
            else
            {
                Console.WriteLine($"dead: {string.Join(" ", playerPosition)}");
            }

        }

        private static void UpdateBunnies(char[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 'B')
                    {
                        // populate upper, lower, left & right '.' positions

                        for (int r = Math.Max(0, i - 1); r <= Math.Min(i + 1, rows - 1); r++)
                        {
                            for (int c = Math.Max(0, j - 1); c <= Math.Min(j + 1, cols - 1); c++)
                            {
                                double distanceToBunny = Math.Sqrt(Math.Pow(i - r, 2) + Math.Pow(j - c, 2));
                                if (distanceToBunny == 1)
                                {
                                    if (matrix[r][c] == 'P')
                                    {
                                        gameOverDead = true;
                                        playerPosition = new int[2] { r, c };
                                        matrix[r][c] = 'b';
                                    }
                                    else if (matrix[r][c] == '.')
                                        matrix[r][c] = 'b';
                                }
                            }
                        }
                    }
                }
            }

            // update new bunnies: 'b' => 'B'
            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    if (matrix[row][col] == 'b')
                        matrix[row][col] = 'B';
        }

        private static void UpdatePlayer(char[][] matrix, char command)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            bool isUpdated = false;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row][col] == 'P')
                    {
                        int stepRow = 0;
                        int stepCol = 0;
                        if (command == 'R') stepCol++;
                        else if (command == 'L') stepCol--;
                        else if (command == 'U') stepRow--;
                        else if (command == 'D') stepRow++;
                        int moveToRow = row + stepRow;
                        int moveToCol = col + stepCol;
                        bool isInside = moveToRow >= 0 && moveToRow < rows &&
                                        moveToCol >= 0 && moveToCol < cols;
                        if (!isInside)
                        {
                            gameOverWon = true;
                            playerPosition = new int[2] { row, col };
                        }
                        else if (matrix[moveToRow][moveToCol] == 'B')
                        {
                            gameOverDead = true;
                            playerPosition = new int[2] { moveToRow, moveToCol };
                        }
                        else
                            matrix[moveToRow][moveToCol] = 'P';
                        matrix[row][col] = '.';
                        isUpdated = true;
                        break;
                    }
                }

                if (isUpdated)
                {
                    break;
                }

            }
        }

        public static char[][] GetMatrix()
        {
            int[] dimensions = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            char[][] matrix = new char[rows][];
            for (int row = 0; row < rows; row++)
                matrix[row] = Console.ReadLine().ToCharArray();
            return matrix;
        }

        public static void PrintMatrix(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
                Console.WriteLine(string.Join("", matrix[row]));
        }

    }
}
