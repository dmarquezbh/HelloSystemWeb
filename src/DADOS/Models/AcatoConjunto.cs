﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AcatoConjunto
    {
        public AcatoConjunto()
        {
            GlosaAcatadaParcial = new HashSet<GlosaAcatadaParcial>();
        }

        public int IdAcatoConjunto { get; set; }
        public decimal? VlTotalAcatado { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public bool? InAtivo { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<GlosaAcatadaParcial> GlosaAcatadaParcial { get; set; }
    }
}