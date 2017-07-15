using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MatrixofPalindromes
{
    class MatrixofPalindromes
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            var matrix = new string[rows][];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = new string[cols];

                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        matrix[rowIndex][colIndex] = alphabet[rowIndex].ToString() + alphabet[rowIndex + colIndex].ToString() + alphabet[rowIndex].ToString();
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
