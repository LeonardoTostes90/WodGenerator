using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WodGenerator.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogsFavoritos : ContentPage
    {
        private enum AbaAtiva : int
        {
            Logs = 1,
            Favoritos = 2
        }

        public LogsFavoritos()
        {
            InitializeComponent();
            CarregarDadosAbaAtiva((int)AbaAtiva.Logs);
            ButtonLogs.BackgroundColor = Color.FromHex("#4A94F5");
        }

        private void CarregarDadosAbaAtiva(int abaAtiva)
        {
            if (abaAtiva == (int)AbaAtiva.Logs)
            {
                ButtonLogs.BackgroundColor = Color.FromHex("#4A94F5");
                ButtonFavoritos.BackgroundColor = Color.FromHex("#E9E9E9");
            }
            else // FAVORITOS
            {
                ButtonFavoritos.BackgroundColor = Color.FromHex("#4A94F5");
                ButtonLogs.BackgroundColor = Color.FromHex("#E9E9E9");
            }
        }

        private void ListViewLogs_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void ButtonLogs_Clicked(object sender, EventArgs e)
        {
            CarregarDadosAbaAtiva(1);
        }

        private void ButtonFavoritos_Clicked(object sender, EventArgs e)
        {
            CarregarDadosAbaAtiva(2);
        }
    }
}