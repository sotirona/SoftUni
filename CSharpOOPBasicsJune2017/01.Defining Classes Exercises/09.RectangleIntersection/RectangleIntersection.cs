using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RectangleIntersection
{
    public class RectangleIntersection
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rectangles = new List<Rectangle>();

            for (int i = 0; i < numbers[0]; i++)
            {
                var input = Console.ReadLine().Split();

                var rectangle = new Rectangle(input[0], double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]), double.Parse(input[4]));
                rectangles.Add(rectangle);
            }

            for (int i = 0; i < numbers[1]; i++)
            {
                var secondInput = Console.ReadLine().Split();
                var firstRect = rectangles.Where(r => r.ID == secondInput[0]).FirstOrDefault();
                var secondRect = rectangles.Where(r => r.ID == secondInput[1]).FirstOrDefault();

                if (firstRect.IsThereIntersection(secondRect))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }
    }
}
