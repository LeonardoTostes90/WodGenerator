    using System;
using System.Collections.Generic;
using System.Text;

namespace WodGenerator.Dominio.Entidades
{
    public abstract class TEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
