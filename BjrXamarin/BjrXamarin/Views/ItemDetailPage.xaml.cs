using BjrXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BjrXamarin.Views
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