﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class JustificativaGlosaFi
    {
        public JustificativaGlosaFi()
        {
            ContaCobranca = new HashSet<ContaCobranca>();
            FaturamentoIndevido = new HashSet<FaturamentoIndevido>();
            Glosa = new HashSet<Glosa>();
            GlosaJustificativaSecundaria = new HashSet<GlosaJustificativaSecundaria>();
            JustificativaGlosaFiComplementar = new HashSet<JustificativaGlosaFiComplementar>();
        }

        public string IdJustificativa { get; set; }
        public string TxDescJustificativa { get; set; }
        public bool? InJustGlosa { get; set; }
        public int IdJustificativaGlosaFi { get; set; }
        public bool? InAtivo { get; set; }
        public bool InUnimed { get; set; }

        public virtual ICollection<ContaCobranca> ContaCobranca { get; set; }
        public virtual ICollection<FaturamentoIndevido> FaturamentoIndevido { get; set; }
        public virtual ICollection<Glosa> Glosa { get; set; }
        public virtual ICollection<GlosaJustificativaSecundaria> GlosaJustificativaSecundaria { get; set; }
        public virtual ICollection<JustificativaGlosaFiComplementar> JustificativaGlosaFiComplementar { get; set; }
    }
}