using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace lab1
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new lab1.MainPage());
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
