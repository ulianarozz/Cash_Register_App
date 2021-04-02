using System;
using System.Collections.Generic;
using System.Text;

/*Uliana Rozzhyvaikina 132294190
 * urozzhyvaikina@myseneca.ca
 * 2021-02-09
 */
namespace Assignment1
{
   public class ProductHistory : Product
    {
        public string purch_time { get; set; }
        public ProductHistory(string name, int qty, double price) : base(name, qty, price)
        {
            purch_time = DateTime.Now.ToString();
        }
    }
}
