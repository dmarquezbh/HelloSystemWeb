﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ExcecaoServicoCompatibilidade
    {
        public int IdRestricao { get; set; }
        public int? IdServicoPrincipal { get; set; }
        public int? IdInstrRegistroPrincTipo { get; set; }
        public int? IdServicoCompativel { get; set; }
        public int? IdInstrRegistroCompTipo { get; set; }
        public int? IdCompatibilidadeTipo { get; set; }
        public bool? InAtivo { get; set; }

        public virtual TipoDiversos IdCompatibilidadeTipoNavigation { get; set; }
        public virtual TipoDiversos IdInstrRegistroCompTipoNavigation { get; set; }
        public virtual TipoDiversos IdInstrRegistroPrincTipoNavigation { get; set; }
        public virtual Servico IdServicoCompativelNavigation { get; set; }
        public virtual Servico IdServicoPrincipalNavigation { get; set; }
    }
}