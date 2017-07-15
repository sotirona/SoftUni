using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseNumbers
{
    public class ReverseNumbers
    {
        public static void Main()
        {

            string[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < array.Length; i++)
            {
                numbers.Push(int.Parse(array[i]));
            }

            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
