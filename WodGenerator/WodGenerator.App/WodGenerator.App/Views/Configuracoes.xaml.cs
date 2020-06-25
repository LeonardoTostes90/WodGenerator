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
    public partial class Configuracoes : ContentPage
    {
        public enum AbaTipoPeso : int
        {
            Libras = 1,
            Quilo = 2
        }

        public Configuracoes()
        {
            InitializeComponent();
            CarregarDadosAbaAtiva((int)AbaTipoPeso.Libras);
            SwitchBackground.Toggled += EnableDisableImageBackground;
        }

        private void CarregarDadosAbaAtiva(int abaTipoPeso)
        {
            if (abaTipoPeso == (int)AbaTipoPeso.Libras)
            {
                ButtonLibras.BackgroundColor = Color.FromHex("#4A94F5");
                ButtonQuilo.BackgroundColor = Color.FromHex("#E9E9E9");
            }
            else // QUILO
            {
                ButtonQuilo.BackgroundColor = Color.FromHex("#4A94F5");
                ButtonLibras.BackgroundColor = Color.FromHex("#E9E9E9");
            }
        }

        private void EnableDisableImageBackground(object sender, EventArgs e)
        {
            //DatePickerReminder.IsEnabled = SwitchReminder.IsToggled;
            //TimePickerReminder.IsEnabled = SwitchReminder.IsToggled;
        }

        private void ButtonLibras_Clicked(object sender, EventArgs e)
        {
            CarregarDadosAbaAtiva((int)AbaTipoPeso.Libras);
        }

        private void ButtonQuilo_Clicked(object sender, EventArgs e)
        {
            CarregarDadosAbaAtiva((int)AbaTipoPeso.Quilo);

        }
    }
}