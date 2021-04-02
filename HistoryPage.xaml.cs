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
    public partial class HistoryPage : ContentPage
    {
        ManagingHistory History = new ManagingHistory();
        public HistoryPage(ManagingHistory history)
        {
            InitializeComponent();
            History = history;
            BindingContext = History.history;
            History_.ItemsSource = History.history;
        }

        async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ProductHistory prodH = History_.SelectedItem as ProductHistory;
            await Navigation.PushModalAsync(new HistoryDetail(prodH));
        }
    }
}