﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class GrupoImposto
    {
        public GrupoImposto()
        {
            GrupoImpostoHistorico = new HashSet<GrupoImpostoHistorico>();
        }

        public int IdGrupoImposto { get; set; }
        public int NrGrupoImposto { get; set; }
        public int IdTipoImposto { get; set; }
        public int IdImposto { get; set; }
        public decimal VlAliquota { get; set; }
        public decimal VlFaixaInicial { get; set; }
        public decimal VlFaixaFinal { get; set; }
        public bool? InAtivo { get; set; }

        public virtual TipoDiversos IdImpostoNavigation { get; set; }
        public virtual TipoDiversos IdTipoImpostoNavigation { get; set; }
        public virtual ICollection<GrupoImpostoHistorico> GrupoImpostoHistorico { get; set; }
    }
}