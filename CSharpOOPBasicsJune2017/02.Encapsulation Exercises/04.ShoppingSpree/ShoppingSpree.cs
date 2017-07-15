using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ShoppingSpree
{
    public class ShoppingSpree
    {
        public static void Main()
        {
            var allPeople = new List<Person>();
            var allProducts = new List<Product>();

            var people = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            var products = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                for (int i = 0; i < people.Length; i++)
                {
                    var peopleSplit = people[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = peopleSplit[0];
                    decimal money = decimal.Parse(peopleSplit[1]);

                    allPeople.Add(new Person(name, money));
                }

                for (int i = 0; i < products.Length; i++)
                {
                    var productsSplit = products[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = productsSplit[0];
                    decimal cost = decimal.Parse(productsSplit[1]);

                    allProducts.Add(new Product(name, cost));

                }

                var purchase = Console.ReadLine();

                while (purchase != "END")
                {
                    var purchaseArgs = purchase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    var buyerName = purchaseArgs[0];
                    var productName = purchaseArgs[1];
                    var currentProduct = allProducts.Where(p => p.Name == productName).FirstOrDefault();
                    var currentBuyer = allPeople.Where(b => b.Name == buyerName).FirstOrDefault();
                    try
                    {
                        currentBuyer.BuyProduct(currentProduct);
                        Console.WriteLine($"{buyerName} bought {productName}");
                    }

                    catch (InvalidOperationException e)
                    {

                        Console.WriteLine(e.Message);
                    }
                   

                    purchase = Console.ReadLine();
                }

                foreach (var person in allPeople)
                {
                    if (person.BagOfProducts.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.BagOfProducts.Select(pr=> pr.Name))}");
                    }
                }
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
