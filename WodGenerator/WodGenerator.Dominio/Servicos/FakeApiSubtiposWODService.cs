using System;
using System.Collections.Generic;
using System.Text;
using WodGenerator.Dominio.DTO;
using WodGenerator.Dominio.Helpers;

namespace WodGenerator.Dominio.Servicos
{
    public class FakeApiSubtiposWODService : ISubtiposWODService
    {
        /// <summary>
        /// Lista todos os Subtipos de WODs
        /// </summary>
        /// <param name="">Identificador do Tipo de WOD</param>
        /// <returns>Lista de Subtipos de WODs</returns>
        public IEnumerable<SubtiposWODDTO> ListarSubTiposWOD(int tipoWODId)
        {
            return HttpHelper.Request<SubtiposWODDTO[]>($"subtiposWOD?WODTipo={tipoWODId}").Result;
        }
    }
}
