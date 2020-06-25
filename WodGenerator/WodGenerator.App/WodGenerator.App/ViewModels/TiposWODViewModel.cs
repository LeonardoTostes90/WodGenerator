using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WodGenerator.Dominio.DTO;
using WodGenerator.Dominio.Entidades;
using WodGenerator.Dominio.Servicos;
using Xamarin.Forms.Xaml;

namespace WodGenerator.App.ViewModels
{
    public class TiposWODViewModel : ViewModelBase
    {
        private ObservableCollection<TiposWOD> tiposWOD;
        public ObservableCollection<TiposWOD> TiposWOD
        {
            get { return tiposWOD; }
            set
            {
                tiposWOD = value;
                OnPropertyChanged();
            }
        }

        public TiposWODViewModel()
        {
            ListarTiposWOD();
        }

        private async void ListarTiposWOD()
        {
            await Task.Run(() =>
            {
                IsLoading = true;

                var servico = ServiceFactory.TiposWODService();
                var DTOTiposWOD = servico.ListarTiposWOD();

                if(DTOTiposWOD.Count() > 0)
                {
                    var lista = new ObservableCollection<TiposWOD>();
                    foreach (var i in DTOTiposWOD)
                    {
                        var tipoWOD = new TiposWOD();

                        // Adicionando informações de Tipos de WOD
                        tipoWOD.Id = i.Id;
                        tipoWOD.Nome = i.Nome;
                        tipoWOD.Descricao = i.Descricao;

                        switch (i.Id)
                        {
                            case (int)WODTiposEnum.AMRAP:
                                tipoWOD.CorTipoWOD = System.Drawing.Color.FromArgb(255, 165, 0);
                                break;
                            case (int)WODTiposEnum.EMOM:
                                tipoWOD.CorTipoWOD = System.Drawing.Color.FromArgb(135, 206, 250);
                                break;
                            case (int)WODTiposEnum.FOR_TIME:
                                tipoWOD.CorTipoWOD = System.Drawing.Color.FromArgb(252, 15, 192);
                                break;
                            case (int)WODTiposEnum.TABATA:
                                tipoWOD.CorTipoWOD = System.Drawing.Color.FromArgb(238, 255, 0);
                                break;
                        }

                        lista.Add(tipoWOD);
                    }
                        TiposWOD = lista;
                }
                isLoading = false;
            });
        }
    }
}
