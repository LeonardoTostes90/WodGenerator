using System;
using System.Collections.Generic;
using System.Text;
using WodGenerator.Dominio.DTO;
using WodGenerator.Dominio.Entidades;

namespace WodGenerator.Dominio.Servicos
{
    public interface IAtletaService
    {
        /// <summary>
        /// Lista todos os atletas registrados
        /// </summary>
        /// <returns>Lista de atletas</returns>
        IEnumerable<AtletaDTO> ListarAtletas();

        /// <summary>
        /// Autentica o atleta registrado
        /// </summary>
        /// <param name="email">E-mail</param>
        /// <param name="senha">Senha</param>
        /// <returns>atleta autenticado</returns>
        AtletaDTO AutenticarAtleta(string email, string senha);
    }
}
