using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WodGenerator.Dominio.Entidades;
using WodGenerator.Dominio.Servicos;

namespace WodGenerator.App.ViewModels
{
    public class SubtiposWODViewModel : ViewModelBase
    {
        private ObservableCollection<SubtiposWOD> subtiposWODs;

        public ObservableCollection<SubtiposWOD> SubtiposWODs
        {
            get { return subtiposWODs; }
            set
            {
                subtiposWODs = value;
                OnPropertyChanged();
            }
        }

        public SubtiposWODViewModel(int tipoWODId)
        {
            CarregarDados(tipoWODId);
        }

        private async void CarregarDados(int tipoWODId)
        {
            await Task.Run(() =>
            {
                IsLoading = true;

                var servico = ServiceFactory.SubtiposWODService();
                var dtos = servico.ListarSubTiposWOD(tipoWODId);

                if(dtos.Count() > 0)
                {
                    var lista = new ObservableCollection<SubtiposWOD>();
                    foreach (var dto in dtos)
                    {
                        var subtiposWOD = new SubtiposWOD();

                        subtiposWOD.WODTipo = dto.WODTipo;
                        subtiposWOD.Id = dto.Id;
                        subtiposWOD.Nome = dto.Nome;
                        subtiposWOD.Descricao = dto.Descricao;

                        switch (dto.WODTipo)
                        {
                            case (int)WODTiposEnum.AMRAP:
                                subtiposWOD.CorTipoWOD = System.Drawing.Color.FromArgb(255, 165, 0);
                                break;
                            case (int)WODTiposEnum.EMOM:
                                subtiposWOD.CorTipoWOD = System.Drawing.Color.FromArgb(135, 206, 250);
                                break;
                            case (int)WODTiposEnum.FOR_TIME:
                                subtiposWOD.CorTipoWOD = System.Drawing.Color.FromArgb(252, 15, 192);
                                break;
                            case (int)WODTiposEnum.TABATA:
                                subtiposWOD.CorTipoWOD = System.Drawing.Color.FromArgb(238, 255, 0);
                                break;
                        }

                        lista.Add(subtiposWOD);
                    }

                SubtiposWODs = lista;
                }
                IsLoading = false;
            });

        }
    }
}
