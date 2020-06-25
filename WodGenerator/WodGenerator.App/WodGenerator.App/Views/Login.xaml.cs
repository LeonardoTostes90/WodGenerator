using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WodGenerator.Dominio.DTO;
using WodGenerator.App.ViewModels;
using WodGenerator.Dominio.Servicos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WodGenerator.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private AtletaViewModel viewModel;

        public Login()
        {
            InitializeComponent();

            this.viewModel = new AtletaViewModel();
            this.BindingContext = viewModel;

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void ButtonLogin_Clicked(object sender, EventArgs e)
        {
            var email = EntryEmail.Text;
            var senha = EntrySenha.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                await this.DisplayAlert("Login", "E-mail e senha são obrigatórios", "OK");
                return;
            }

            AtletaDTO atleta = await viewModel.AutenticarAtleta(EntryEmail.Text, EntrySenha.Text);

            if (atleta != null)
            {
                ButtonLogin.IsEnabled = false;
                App.AtletaId = atleta.Id;
                Navigation.InsertPageBefore(new Default(), this);
                await Navigation.PopAsync().ConfigureAwait(false);
            }
            else
            {
                await this.DisplayAlert("Login", "Atleta não encontrado", "OK");
                ButtonLogin.IsEnabled = true;
            }
        }
    }
}