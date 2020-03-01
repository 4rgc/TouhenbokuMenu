using System;
using System.Collections.Generic;
using Menu.ViewModels;
using Xamarin.Forms;

namespace Menu.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string dbPath)
        {
            InitializeComponent();

            BindingContext = new MainViewModel(dbPath);
        }
    }
}
