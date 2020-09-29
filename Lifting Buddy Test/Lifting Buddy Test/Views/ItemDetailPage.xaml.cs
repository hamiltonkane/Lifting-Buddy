using System.ComponentModel;
using Xamarin.Forms;
using Lifting_Buddy_Test.ViewModels;

namespace Lifting_Buddy_Test.Views
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