using System;
using System.Collections.Generic;
using FashionMobileApp.ViewModels;

using Xamarin.Forms;

namespace FashionMobileApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new FashionViewModel();
        }
    }
}
