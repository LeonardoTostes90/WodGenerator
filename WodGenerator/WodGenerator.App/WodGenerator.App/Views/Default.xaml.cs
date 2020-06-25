using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WodGenerator.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Default : ContentPage
    {
        public Default()
        {   
            InitializeComponent();
        }

        public ICommand ClickLogFavoritosCommand => new Command<string>((url) =>
        {
            Navigation.PushModalAsync(new Configuracoes(), true);
        });

        private async void ImageButtonCriaWod_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new TiposWOD(), true);
        }

        private async void ImageButtonConfiguracoes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Configuracoes(), true);
        }

        private void ImageButtonGo_Clicked(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizerLogFavoritos_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new LogsFavoritos(), true);
        }
    }
}