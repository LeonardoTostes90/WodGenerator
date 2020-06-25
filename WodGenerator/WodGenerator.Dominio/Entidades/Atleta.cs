using System;
using System.Collections.Generic;
using System.Text;

namespace WodGenerator.Dominio.Entidades
{
    public class Atleta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime Data_Criacao { get; set; }
        public DateTime Data_Atualizacao { get; set; }

        //public virtual ICollection<Equipamentos> Equipamentos { get; set; }
        //public virtual ICollection<Habilidades> Habilidades { get; set; }
        //public virtual ICollection<WODs> WODs { get; set; }
        //public virtual ICollection<WODLogs> Logs { get; set; }
        //public virtual ICollection<WODFavoritos> Favoritos { get; set; }
    }
}
