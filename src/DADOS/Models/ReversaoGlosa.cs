﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ReversaoGlosa
    {
        public ReversaoGlosa()
        {
            ReversaoGlosaParcial = new HashSet<ReversaoGlosaParcial>();
        }

        public int IdFechamentoItem { get; set; }
        public int IdConta { get; set; }
        public double VlRevertido { get; set; }
        public DateTime DataReversao { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public int IdUsuario { get; set; }
        public int? IdNotaEmitida { get; set; }
        public bool? InPaga { get; set; }

        public virtual NotaEmitida IdNotaEmitidaNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual ICollection<ReversaoGlosaParcial> ReversaoGlosaParcial { get; set; }
    }
}