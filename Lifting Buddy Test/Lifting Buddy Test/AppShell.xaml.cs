using System;
using System.Collections.Generic;
using Lifting_Buddy_Test.ViewModels;
using Lifting_Buddy_Test.Views;
using Xamarin.Forms;

namespace Lifting_Buddy_Test
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
