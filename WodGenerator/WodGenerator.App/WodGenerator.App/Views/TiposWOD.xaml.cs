using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WodGenerator.App.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WodGenerator.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TiposWOD : ContentPage
    {

        private TiposWODViewModel viewModel;
        bool dadosCarregados = false;

        public TiposWOD()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(!dadosCarregados)
            {
                viewModel = new TiposWODViewModel();
                this.BindingContext = viewModel;
                dadosCarregados = true;
            }
        }

        private async void ListViewTiposWOD_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tipoWOD = e.Item as Dominio.Entidades.TiposWOD;
            await Navigation.PushModalAsync(new SubtiposWOD(tipoWOD.Id), true);
        }
    }
}