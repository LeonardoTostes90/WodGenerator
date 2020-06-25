using System;
using System.Collections.Generic;
using System.Text;

namespace WodGenerator.Dominio.Entidades
{
    public class SubtiposWOD
    {
        public int WODTipo { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public System.Drawing.Color CorTipoWOD { get; set; }
    }
}
