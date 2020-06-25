using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WodGenerator.Dominio.DTO;
using WodGenerator.Dominio.Servicos;

namespace WodGenerator.App.ViewModels
{
    public class AtletaViewModel : ViewModelBase
    {
        public async Task<AtletaDTO> AutenticarAtleta(string email, string senha)
        {
            AtletaDTO atleta = null;   
            IsLoading = true;
            await Task.Run(() =>
            {
                var servico = ServiceFactory.AtletaService();
                atleta = servico.AutenticarAtleta(email, senha);
            });
            IsLoading = false;
            return atleta;
        }
    }
}
