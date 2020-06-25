using System;
using System.Collections.Generic;
using System.Text;
using WodGenerator.Dominio.DTO;
using WodGenerator.Dominio.Entidades;
using WodGenerator.Dominio.Helpers;
using WodGenerator.Dominio.Servicos;

namespace WodGenerator.Dominio.Servicos
{
    public class FakeApiAtletaService : IAtletaService
    {
        /// <summary>
        /// Autentica um atleta na API
        /// </summary>
        /// <param name="email">E-mail do atleta</param>
        /// <param name="senha">Senha do atleta</param>
        /// <returns>atleta autenticado</returns>
        public AtletaDTO AutenticarAtleta(string email, string senha)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
                return null;

            string requestUrl = $"atletas?email={email}&senha={senha}".Replace(" ", "");
            var atletas = HttpHelper.Request<AtletaDTO[]>(requestUrl).Result;

            if (atletas.Length.Equals(0)) return null;
            else return atletas[0];
        }

        /// <summary>
        /// Lista todos os atletas registrados
        /// </summary>
        /// <returns>Lista de participantes</returns>
        public IEnumerable<AtletaDTO> ListarAtletas()
        {
            return HttpHelper.Request<AtletaDTO[]>("atletas").Result;
        }
    }
}
