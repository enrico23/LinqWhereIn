using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWhereIn
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqTest.test();
            Console.ReadKey();
        }
    }

    public static class LinqTest
    {
        public static void test() {
            List<Products> ShopProducts = new List<Products>();
            ShopProducts.Add(new Products { id = 1, name = "Product 1" });
            ShopProducts.Add(new Products { id = 2, name = "Product 2" });
            ShopProducts.Add(new Products { id = 3, name = "Product 3" });
            ShopProducts.Add(new Products { id = 4, name = "Product 4" });
            ShopProducts.Add(new Products { id = 5, name = "Product 5" });

            List<int> selectedProducts = new List<int>{ 1, 5 };

            var ShoppingCart = (from e in ShopProducts
                                    where selectedProducts.Contains((int)e.id)
                                    select e).ToList();

            Console.WriteLine("The shopping cart contains : " + ShoppingCart.Count() + " products.");

            foreach(var item in ShoppingCart){
                Console.WriteLine(item.name);
            }
           
        }
    }

    public class Products {
        public int id { get; set; }
        public string name { get; set; }
    }
    

}
