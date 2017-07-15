using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MapDistricts
{
    class MapDistricts
    {
        static void Main(string[] args)
        {
            var info = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var minPopulation = long.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<long>>();

            foreach (var kvp in info)
            {
                var infoArgs = kvp.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                var city = infoArgs[0];
                var population = long.Parse(infoArgs[1]);

                if (!dict.ContainsKey(city))
                {
                    dict.Add(city, new List<long>());
                }

                dict[city].Add(population);

            }

            foreach (var kvp in dict.Where(x => x.Value.Sum() >= minPopulation).OrderByDescending(x=>x.Value.Sum()))
            {
                var list = kvp.Value.OrderByDescending(x => x).Take(5).ToList();

                Console.WriteLine($"{kvp.Key}: {string.Join(" ", list)}");
            }

        }
    }
}
