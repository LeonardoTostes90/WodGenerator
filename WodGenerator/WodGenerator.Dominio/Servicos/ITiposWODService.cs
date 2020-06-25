using System;
using System.Collections.Generic;
using System.Text;
using WodGenerator.Dominio.DTO;
using WodGenerator.Dominio.Entidades;

namespace WodGenerator.Dominio.Servicos
{
    public interface ITiposWODService
    {
        /// <summary>
        /// Lista todos os tipos de WODs registrados
        /// </summary>
        /// <returns>Lista de Tipos de WODs</returns>
        IEnumerable<TiposWODDTO> ListarTiposWOD();
    }
}
