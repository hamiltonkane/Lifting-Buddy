using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Lifting_Buddy_Test.Models;
using Lifting_Buddy_Test.Views;
using Lifting_Buddy_Test.ViewModels;

namespace Lifting_Buddy_Test.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public List<Item> temp;

        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                ItemsListView.ItemsSource = temp;
            }

            else
            {
                ItemsListView.ItemsSource = temp.Where(x => x.Text.StartsWith(e.NewTextValue));
            }
        }
    }
}