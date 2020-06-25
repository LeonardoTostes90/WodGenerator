using System;
using System.Collections.Generic;
using System.Text;
using WodGenerator.Dominio.DTO;
using WodGenerator.Dominio.Entidades;
using WodGenerator.Dominio.Helpers;
using WodGenerator.Dominio.Servicos;

namespace WodGenerator.Dominio.Servicos
{
    public class FakeApiTiposWODService : ITiposWODService
    {

        /// <summary>
        /// Lista todos os atletas registrados
        /// </summary>
        /// <returns>Lista de participantes</returns>
        public IEnumerable<TiposWODDTO> ListarTiposWOD()
        {
            return HttpHelper.Request<TiposWODDTO[]>("tiposWOD").Result;
        }

    }
}
