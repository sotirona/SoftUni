using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLength
{
    public class StringLength
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToList();

            while (text.Count < 20)
            {
                text.Add('*');
            }

            foreach (var item in text.Take(20))
            {
                Console.Write(item);
            }
            
        }
    }
}
