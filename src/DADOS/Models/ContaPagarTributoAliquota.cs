﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ContaPagarTributoAliquota
    {
        public ContaPagarTributoAliquota()
        {
            GuiaFiscalContaPagarTributoAliquota = new HashSet<GuiaFiscalContaPagarTributoAliquota>();
            InverseIdContaPagarTributoAliquotaPaiNavigation = new HashSet<ContaPagarTributoAliquota>();
            ParcelaContaPagarBaixaContaPagarTributoAliquota = new HashSet<ParcelaContaPagarBaixaContaPagarTributoAliquota>();
        }

        public int IdContaPagarTributoAliquota { get; set; }
        public int IdContaPagar { get; set; }
        public int IdTributoAliquota { get; set; }
        public int IdTipoRegimeRecolhimento { get; set; }
        public decimal VlBaseCalculo { get; set; }
        public decimal VlTributo { get; set; }
        public bool InBaixado { get; set; }
        public int? IdParcelacontapagarBaixaBaixa { get; set; }
        public int? IdParcelacontapagarBaixaOrigem { get; set; }
        public int? IdContaPagarTributoAliquotaPai { get; set; }
        public DateTime? DtVencimento { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public bool? InAtivo { get; set; }

        public virtual ContaPagar IdContaPagarNavigation { get; set; }
        public virtual ContaPagarTributoAliquota IdContaPagarTributoAliquotaPaiNavigation { get; set; }
        public virtual ParcelaContaPagarBaixa IdParcelacontapagarBaixaBaixaNavigation { get; set; }
        public virtual ParcelaContaPagarBaixa IdParcelacontapagarBaixaOrigemNavigation { get; set; }
        public virtual TipoDiversos IdTipoRegimeRecolhimentoNavigation { get; set; }
        public virtual TributoAliquota IdTributoAliquotaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<GuiaFiscalContaPagarTributoAliquota> GuiaFiscalContaPagarTributoAliquota { get; set; }
        public virtual ICollection<ContaPagarTributoAliquota> InverseIdContaPagarTributoAliquotaPaiNavigation { get; set; }
        public virtual ICollection<ParcelaContaPagarBaixaContaPagarTributoAliquota> ParcelaContaPagarBaixaContaPagarTributoAliquota { get; set; }
    }
}