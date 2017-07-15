using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FirstName
{
    class FirstName
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var hashSet = new HashSet<string>(Console.ReadLine().Split()).Select(x=>x.ToLower());
            var result = names.Where(x => hashSet.Contains(x[0].ToString().ToLower())).OrderBy(x => x).FirstOrDefault();

            if (result==null)
            {
                Console.WriteLine("No match");
            }
            else
            {
                Console.WriteLine(result);

            }

        }
    }
}
