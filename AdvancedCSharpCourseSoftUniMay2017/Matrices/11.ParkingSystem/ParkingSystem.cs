using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ParkingSystem
{
    class ParkingSystem
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
               .Split()
               .Select(x => x.Trim())
               .Select(int.Parse)
               .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            Dictionary<int, HashSet<int>> parking = new Dictionary<int, HashSet<int>>();

            string[] input = Console.ReadLine()
                .Split()
                .Select(x => x.Trim())
                .ToArray();

            while (!input[0].Equals("stop"))
            {
                int enter = int.Parse(input[0]);
                int desiredRow = int.Parse(input[1]);
                int desiredCol = int.Parse(input[2]);

                if (!IsOccupied(parking, desiredRow, desiredCol))
                {
                    if (!parking.ContainsKey(desiredRow))
                    {
                        parking.Add(desiredRow, new HashSet<int>());
                    }

                    parking[desiredRow].Add(desiredCol);

                    int count = Math.Abs(enter - desiredRow) + 1 + desiredCol;
                    Console.WriteLine(count);
                }

                else
                {
                    desiredCol = TryFindEmptySpace(parking[desiredRow], cols, desiredCol );

                    if (desiredCol == 0)
                    {
                        Console.WriteLine($"Row {desiredRow} full");
                    }
                    else 
                    {
                        if (!parking.ContainsKey(desiredRow))
                        {
                            parking.Add(desiredRow,new HashSet<int>());
                        }
                        parking[desiredRow].Add(desiredCol);

                        int count = Math.Abs(enter - desiredRow) + 1 + desiredCol;
                        Console.WriteLine(count);
                    }

                }

                input = Console.ReadLine()
                    .Split()
                    .Select(x => x.Trim())
                    .ToArray();
            }
        }

        private static int TryFindEmptySpace(HashSet<int> hashSet, int cols, int desiredCol)
        {
            int targetColIndex = 0;
            int minDistance = int.MaxValue;

            if (hashSet.Count == cols - 1)
            {
                return targetColIndex;
            }

            else
            {
                for (int i = 1; i < cols; i++)
                {
                    int currentDistance = Math.Abs(desiredCol - i);
                    if (!hashSet.Contains(i) && currentDistance < minDistance)
                    {
                        targetColIndex = i;
                        minDistance = currentDistance;
                    }
                }
                return targetColIndex;
            }
        }

        private static bool IsOccupied(Dictionary<int, HashSet<int>> parking, int desiredRow, int desiredCol)
        {
            return parking.ContainsKey(desiredRow) && parking[desiredRow].Contains(desiredCol);
        }
    }
}
