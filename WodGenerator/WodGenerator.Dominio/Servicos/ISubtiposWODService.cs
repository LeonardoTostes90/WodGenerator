using System;
using System.Collections.Generic;
using System.Text;
using WodGenerator.Dominio.DTO;

namespace WodGenerator.Dominio.Servicos
{
    public interface ISubtiposWODService
    {
        // <summary>
        /// Lista todos os Subtipos de WODs
        /// </summary>
        /// <param name="">Identificador do Tipo de WOD</param>
        /// <returns>Lista de Subtipos de WODs</returns>
        IEnumerable<SubtiposWODDTO> ListarSubTiposWOD(int tipoWODId);
    }
}
