using Exemple.Xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Exemple.Xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}