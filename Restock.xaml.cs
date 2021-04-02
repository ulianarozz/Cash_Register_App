using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/*Uliana Rozzhyvaikina 132294190
 * urozzhyvaikina@myseneca.ca
 * 2021-02-09
 */
namespace Assignment1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Restock : ContentPage
    {
        Product selectedItem;
        ManagingProd Products = new ManagingProd();
        public Restock(ManagingProd product)
        {
            InitializeComponent();
            Products = product;
            BindingContext = Products.products;
            allItems.ItemsSource = Products.products;
        }

        async void Restock_Clicked(object sender, EventArgs e)
        {
            if (selectedItem == null)
            {
              await  DisplayAlert("Warning!","No item selected","OK");
            }
            else
            {
                if (NewQty.Text == null)
                {
                  await  DisplayAlert("Warning!", "Please select quantity", "OK");
                }
                else
                {

                    Products.Update(selectedItem, int.Parse(NewQty.Text));
                    allItems.ItemsSource = Products.products;
                    await DisplayAlert("Message", "Item was restocked", "Go back");
                    await Navigation.PopModalAsync();
                }
            }
        }
       async void Cancel_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PopModalAsync();
        }

        public void allItems_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            selectedItem = allItems.SelectedItem as Product;
        }
    }
}