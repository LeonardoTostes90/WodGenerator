using System;
using System.Collections.Generic;
using System.Text;

namespace WodGenerator.Dominio.Entidades
{
    public enum WODTiposEnum : int
    {
        AMRAP = 1,
        EMOM = 2,
        FOR_TIME = 3,
        TABATA = 4
    }

    public class TiposWOD 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public System.Drawing.Color CorTipoWOD { get; set; }
    }
}
