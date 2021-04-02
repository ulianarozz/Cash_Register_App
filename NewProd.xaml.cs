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
    public partial class NewProd : ContentPage
    {
        ManagingProd Products;
        public NewProd(ManagingProd prod)
        {
            InitializeComponent();
            Products = prod;
        }

        async void Add_Clicked(object sender, EventArgs e)
        {
            Products.Add(n_name.Text, int.Parse(n_qty.Text),double.Parse(n_price.Text));
            await DisplayAlert("Message","Item was added","Go back");
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}