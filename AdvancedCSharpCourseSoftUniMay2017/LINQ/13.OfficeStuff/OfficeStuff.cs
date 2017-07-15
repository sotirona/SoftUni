using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.OfficeStuff
{
    class OfficeStuff
    {
        static void Main(string[] args)
        {

            var dict = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new string[] { "|", " - " }, StringSplitOptions.RemoveEmptyEntries);
                var company = input[0];
                var product = input[2];
                int amount = int.Parse(input[1]);

                if (!dict.ContainsKey(company))
                {
                    dict.Add(company, new Dictionary<string, int>());
                    
                }
                if (!dict[company].ContainsKey(product))
                {
                    dict[company].Add(product, 0);
                }

                dict[company][product] += amount;
               
            }

            foreach (var outerKVP in dict.OrderBy(x=>x.Key))
            {
                Console.Write($"{outerKVP.Key}: ");
                int count = 1;

                foreach (var innerKVP in outerKVP.Value)
                {
                    if (count<outerKVP.Value.Count)
                    {
                        Console.Write($"{innerKVP.Key}-{innerKVP.Value}, ");
                        count++;
                    }
                    else
                    {
                        Console.Write($"{innerKVP.Key}-{innerKVP.Value}");

                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
