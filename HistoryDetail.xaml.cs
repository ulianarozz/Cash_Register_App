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
    public partial class HistoryDetail : ContentPage
    {
        public HistoryDetail(ProductHistory product)
        {
            InitializeComponent();
            BindingContext = product;
        }
    }
}