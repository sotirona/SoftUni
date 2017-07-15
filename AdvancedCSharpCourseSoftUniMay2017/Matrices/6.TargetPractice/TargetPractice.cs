using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.TargetPractice
{
    class TargetPractice
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string name = Console.ReadLine().Trim();
            var parameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = sizes[0];
            int cols = sizes[1];
            int impactRow = parameters[0];
            int impactCol = parameters[1];
            int radius = parameters[2];

            var matrix = new char[rows][];

            for (int rowvIndex = 0; rowvIndex < rows; rowvIndex++)
            {
                matrix[rowvIndex] = new char[cols];
            }


            //filling the matrix

            int counter = 0;
            int rowChecker = 0;

            for (int rowIndex = rows - 1; rowIndex >= 0; rowIndex--)
            {
                rowChecker++;
                if (rowChecker % 2 == 0)
                {
                    for (int colIndex = 0; colIndex < cols; colIndex++)
                    {
                        matrix[rowIndex][colIndex] = name[counter % name.Length];
                        counter++;
                    }
                }

                else
                {
                    for (int colIndex = cols - 1; colIndex >= 0; colIndex--)
                    {
                        matrix[rowIndex][colIndex] = name[counter % name.Length];
                        counter++;

                    }
                }
            }

            // bombing and clearing the field

            int target = matrix[impactRow][impactCol];

            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    if ((rowIndex - impactRow) * (rowIndex - impactRow) + (colIndex - impactCol) * (colIndex - impactCol) <= radius * radius)
                    {
                        matrix[rowIndex][colIndex] = ' ';
                    }
                }
            }

            // charаcters falling down

            for (int colIndex = 0; colIndex < cols; colIndex++)
            {
                var temp = new char[rows];

                for (int rowIndex = 0; rowIndex < rows; rowIndex++)
                {
                    temp[rowIndex] = matrix[rowIndex][colIndex];
                }

                temp = temp.OrderByDescending(x => x == ' ').ToArray();

                for (int rowIndex = 0; rowIndex < rows; rowIndex++)
                {
                    matrix[rowIndex][colIndex] = temp[rowIndex];
                }
            }

            // printing

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }


        }
    }
}
