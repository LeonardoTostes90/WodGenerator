using System;
using System.Collections.Generic;
using System.Text;

namespace WodGenerator.Dominio.Entidades
{
    public enum WODSubTiposTABATAEnum : int
    {
        TABATA_Padrao = 1,
        TABATA_Alternada = 2
    }

    public class WODSubTiposTABATA 
    {
        public int IdSubTipo { get; set; }
        public string NomeSubTipo { get; set; }
        public string DescricaoSubTipo { get; set; }
    }
}
