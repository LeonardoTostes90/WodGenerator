using System;
using WodGenerator.App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WodGenerator.App
{
    public partial class App : Application
    {
        public static int? AtletaId { get; set; }

        public App()
        {
            InitializeComponent();
            MainPage = new Login();
        }

        public App(bool atletaAutenticado)
        {
            InitializeComponent();

            if (atletaAutenticado)
            {
                AtletaId = 1;
                MainPage = new NavigationPage(new Default());
            }
            else MainPage = new NavigationPage(new Login());
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
