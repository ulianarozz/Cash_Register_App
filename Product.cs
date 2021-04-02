using System;
using System.Collections.Generic;
using System.Text;
/*Uliana Rozzhyvaikina 132294190
 * urozzhyvaikina@myseneca.ca
 * 2021-02-09
 */
namespace Assignment1
{
    public class Product
    {
        public string Name { get; set; }
        public int qty { get; set; }
        public double price { get; set; }

        public Product(string name, int qty, double price)
        {
            this.Name = name;
            this.qty = qty;
            this.price = price;
        }
    }
}
/*    products = new ObservableCollection<Product>
         {
             new Product("pants" ,100, 45.8),
             new Product("hats" ,40,21.9),
             new Product( "shoes" , 34,113.4),
             new Product("tShirts" , 90, 15.0),
             new Product("dresses" , 10, 65.5),
         };
            allItems.ItemsSource = products;
        }*/
