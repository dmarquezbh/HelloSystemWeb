﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class JustificativaRecurso
    {
        public JustificativaRecurso()
        {
            RecursoGlosa = new HashSet<RecursoGlosa>();
        }

        public int IdJustificativaRecurso { get; set; }
        public string TxDescricao { get; set; }
        public string TxTitulo { get; set; }
        public bool? InAtivo { get; set; }

        public virtual ICollection<RecursoGlosa> RecursoGlosa { get; set; }
    }
}