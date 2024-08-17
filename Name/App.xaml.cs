using Name.Views.Home;
using Name.Views.Productos;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Name
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new VHPrincipal());
            MainPage = new VHPrincipal();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
