using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Assignment1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManagerMenu : ContentPage
    {
        ManagingHistory History = new ManagingHistory();
        ManagingProd Products = new ManagingProd();
        public ManagerMenu(ManagingProd manager, ManagingHistory history)
        {
            InitializeComponent();
            History = history;
            Products = manager;
        }

        async void History_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new HistoryPage(History));
        }

       async void Restock_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Restock(Products));
        }

        async void Add_New_Prod(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewProd(Products));
        }

    }
}