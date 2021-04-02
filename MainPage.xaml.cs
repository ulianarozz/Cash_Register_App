using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

/*Uliana Rozzhyvaikina 132294190
 * urozzhyvaikina@myseneca.ca
 * 2021-02-09
 */
namespace Assignment1
{
    public partial class MainPage : ContentPage
    {
        Product selectedItem;
        ManagingHistory SoldProd = new ManagingHistory();
        ManagingProd Products = new ManagingProd();
        public MainPage()
        {
            
            InitializeComponent();
            BindingContext = Products.products;
            allProducts.ItemsSource = Products.products;
        }
        public void Clear_Clicked(object sender, EventArgs e)
        {
            selected_qty.Text = "0";
            selected_price.Text = "0";
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button digit = (Button)sender;
            double num = Double.Parse(digit.Text);
            selected_qty.Text = (Double.Parse(selected_qty.Text) * 10 + num).ToString();

            if (selectedItem != null)
                selected_price.Text = (selectedItem.price * Double.Parse(selected_qty.Text)).ToString();

        }
        private void Buy_Clicked(object sender, EventArgs e)
        {
            if (selectedItem == null || string.IsNullOrEmpty(selected_qty.Text))
            {
                DisplayAlert("Error", "Item was not chosen!", "Cancel");
                //  
            }else
            {
                if (int.Parse(selected_qty.Text) > selectedItem.qty)
                {
                    DisplayAlert("Warning!", "There is not enough stock!", "Cancel");
                }
                else
                {
                    selectedItem.qty -= int.Parse(selected_qty.Text);
                    SoldProd.history.Add(new ProductHistory(selectedItem.Name, int.Parse(selected_qty.Text), double.Parse(selected_price.Text)));
                    selected_qty.Text = "0";
                    selected_price.Text = "0";
                    selected_item.Text = "Type";
                    total.Text = "Total";
                    allProducts.ItemsSource = Products.products;
                }
            }

        }

       

        public void Product_Selected(object sender, EventArgs prod)
        {
          selectedItem = allProducts.SelectedItem as Product;
           selected_item.Text = selectedItem.Name;
            selected_price.Text = selectedItem.price.ToString();

           double temp = (selectedItem.price * Double.Parse(selected_qty.Text));
            total.Text = temp.ToString();
      
        }

      async void Manager_Clicked(object sender, EventArgs e) {
            await Navigation.PushModalAsync(new ManagerMenu(Products, SoldProd));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            allProducts.ItemsSource = null;
            allProducts.ItemsSource = Products.products;
        }
    }
}
