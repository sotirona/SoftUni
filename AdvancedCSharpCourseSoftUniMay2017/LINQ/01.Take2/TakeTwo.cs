using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Take2
{
    public class TakeTwo
    {
        public static void Main()
        {
            //var input = Console.ReadLine().Split().Select(int.Parse).Where(x => x >= 10 && x <= 20).Distinct().ToList()    ;
            //input.Take(2).ToList().ForEach(n => Console.Write(n + " "));

            Console.ReadLine().Split(' ').Select(int.Parse).Where(n => n >= 10 && n <= 20).Distinct().Take(2).ToList().ForEach(n => Console.Write(n + " "));


        }
    }
}
