using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

/*Uliana Rozzhyvaikina 132294190
 * urozzhyvaikina@myseneca.ca
 * 2021-02-09
 */
namespace Assignment1
{
   public class ManagingProd
    {
      public Collection<Product> products;
        public ManagingProd()
        {
            products = new Collection<Product>
            {
             new Product("pants" ,100, 45.8),
             new Product("hats" ,40,21.9),
             new Product( "shoes" , 34,113.4),
             new Product("tShirts" , 90, 15.0),
             new Product("dresses" , 10, 65.5),
            };
        }
        public void Update(Product prd, int stock)
        {
            prd.qty = stock;
        }
        public void Add(string name, int qty, double price)
        {
            products.Add(new Product(name, qty, price));
        }
    }
    public class ManagingHistory
    {
        public ObservableCollection<ProductHistory> history = new ObservableCollection<ProductHistory>();
        public ManagingHistory() {
        }
    }
}
