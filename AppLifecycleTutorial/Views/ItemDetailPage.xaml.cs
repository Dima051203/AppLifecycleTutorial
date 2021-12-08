using AppLifecycleTutorial.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppLifecycleTutorial.Views
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