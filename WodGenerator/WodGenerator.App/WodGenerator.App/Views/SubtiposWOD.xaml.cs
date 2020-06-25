using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WodGenerator.App.ViewModels;
using WodGenerator.Dominio.Entidades;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WodGenerator.App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubtiposWOD : ContentPage
    {
        private SubtiposWODViewModel viewModel;
        bool dadosCarregados = false;
        int tipoWODId;

        public SubtiposWOD(int tipoWOD)
        {
            InitializeComponent();
            tipoWODId = tipoWOD;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (!dadosCarregados)
            {
                viewModel = new SubtiposWODViewModel(tipoWODId);
                this.BindingContext = viewModel;
                dadosCarregados = true;
                DefinirTextoLabels();                
            }
        }

        private void DefinirTextoLabels()
        {
            string lblSubtipoWOD = "Escolha o tipo de";

            switch (tipoWODId)
            {
                case (int)WODTiposEnum.AMRAP:
                    LabelTituloSubTipoWOD.Text = WODTiposEnum.AMRAP.ToString();
                    LabelEscolhaSubTipoWOD.Text = lblSubtipoWOD + ' ' + LabelTituloSubTipoWOD.Text;
                    LabelTituloSubTipoWOD.TextColor = System.Drawing.Color.FromArgb(255, 165, 0);
                    break;
                case (int)WODTiposEnum.EMOM:
                    LabelTituloSubTipoWOD.Text = WODTiposEnum.EMOM.ToString();
                    LabelEscolhaSubTipoWOD.Text = lblSubtipoWOD + ' ' + LabelTituloSubTipoWOD.Text;
                    LabelTituloSubTipoWOD.TextColor = System.Drawing.Color.FromArgb(135, 206, 250);
                    break;
                case (int)WODTiposEnum.FOR_TIME:
                    LabelTituloSubTipoWOD.Text = WODTiposEnum.FOR_TIME.ToString().Replace("_", " ");
                    LabelEscolhaSubTipoWOD.Text = lblSubtipoWOD + ' ' + LabelTituloSubTipoWOD.Text;
                    LabelTituloSubTipoWOD.TextColor = System.Drawing.Color.FromArgb(252, 15, 192);
                    break;
                case (int)WODTiposEnum.TABATA:
                    LabelTituloSubTipoWOD.Text = WODTiposEnum.TABATA.ToString();
                    LabelEscolhaSubTipoWOD.Text = lblSubtipoWOD + ' ' + LabelTituloSubTipoWOD.Text;
                    LabelTituloSubTipoWOD.TextColor = System.Drawing.Color.FromArgb(238, 255, 0);
                    break;
            }
        }

        private void ListViewSubTiposWOD_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var subTipoWOD = e.Item as WODSubTiposTABATA;
            //DisplayAlert("TESTE", subTipoWOD.Id.ToString(), "OK");
        }

    }
}