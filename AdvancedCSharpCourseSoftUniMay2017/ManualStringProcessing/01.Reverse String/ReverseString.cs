using System;


namespace _01.Reverse_String
{
    public class ReverseString
    {
        public static void Main()
        {
            char[] text = Console.ReadLine().ToCharArray();

            Array.Reverse(text);

            Console.WriteLine(text);
        }
    }
}
