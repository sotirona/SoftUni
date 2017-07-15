using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mankind
{
   public class Mankind
    {
       public static void Main()
        {
            try
            {
                var studentArgs = Console.ReadLine().Split();
                var workerArgs = Console.ReadLine().Split();
                var student = new Student(studentArgs[0], studentArgs[1], studentArgs[2]);
                var worker = new Worker(workerArgs[0], workerArgs[1], decimal.Parse(workerArgs[2]), decimal.Parse(workerArgs[3]));
                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
