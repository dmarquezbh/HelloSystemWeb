﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CartaRecursoRecusoGlosaGenerica
    {
        public int IdConta { get; set; }
        public int IdCartarecurso { get; set; }
        public int IdUsuario { get; set; }

        public virtual CartaRecurso IdCartarecursoNavigation { get; set; }
        public virtual RecursoGlosaGenerica IdContaNavigation { get; set; }
    }
}