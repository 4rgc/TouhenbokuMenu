using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Menu.Views;

namespace Menu
{
    public partial class App : Application
    {
        public App(string dbPath)
        {
            InitializeComponent();

            MainPage = new TabbedPage()
            {
                Children =
                {
                    new MainPage(dbPath)
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
