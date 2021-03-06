﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ContaPagarDes
    {
        public int IdContaPagar { get; set; }
        public int? IdTipoSerieNf { get; set; }
        public int? IdTipoModeloDoc { get; set; }
        public int? IdTipoMotivoNaoRetencao { get; set; }
        public int IdLocalidadePrestacao { get; set; }
        public decimal PrAliquota { get; set; }
        public decimal VlBaseCalculo { get; set; }
        public bool? InAtivo { get; set; }
        public DateTime DtCadastro { get; set; }
        public int IdUsuario { get; set; }
        public int? IdLogradouroPrestacao { get; set; }
        public string NrInscricaoMunicipal { get; set; }

        public virtual ContaPagar IdContaPagarNavigation { get; set; }
        public virtual LogLocalidade IdLocalidadePrestacaoNavigation { get; set; }
        public virtual LogLogradouro IdLogradouroPrestacaoNavigation { get; set; }
        public virtual TipoDiversos IdTipoModeloDocNavigation { get; set; }
        public virtual TipoDiversos IdTipoMotivoNaoRetencaoNavigation { get; set; }
        public virtual TipoDiversos IdTipoSerieNfNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}