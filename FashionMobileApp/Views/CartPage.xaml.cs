using System;
using System.Collections.Generic;
using FashionMobileApp.ViewModels;
using Xamarin.Forms;

namespace FashionMobileApp.Views
{
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            BindingContext = new FashionViewModel();
        }
    }
}
