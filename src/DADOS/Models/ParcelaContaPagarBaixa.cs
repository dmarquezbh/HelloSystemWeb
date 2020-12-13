﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ParcelaContaPagarBaixa
    {
        public ParcelaContaPagarBaixa()
        {
            ContaPagarTributoAliquotaIdParcelacontapagarBaixaBaixaNavigation = new HashSet<ContaPagarTributoAliquota>();
            ContaPagarTributoAliquotaIdParcelacontapagarBaixaOrigemNavigation = new HashSet<ContaPagarTributoAliquota>();
            ContaReceber = new HashSet<ContaReceber>();
            InverseIdParcelacontapagarBaixaEstornadaNavigation = new HashSet<ParcelaContaPagarBaixa>();
            LancamentoBancario = new HashSet<LancamentoBancario>();
            ParcelaContaPagarBaixaAcrescimo = new HashSet<ParcelaContaPagarBaixaAcrescimo>();
            ParcelaContaPagarBaixaContaPagarTributoAliquota = new HashSet<ParcelaContaPagarBaixaContaPagarTributoAliquota>();
            ParcelaContaPagarBaixaDesconto = new HashSet<ParcelaContaPagarBaixaDesconto>();
            ParcelaContaReceberBaixa = new HashSet<ParcelaContaReceberBaixa>();
        }

        public int IdParcelacontapagarBaixa { get; set; }
        public int IdContaPagar { get; set; }
        public int NrParcela { get; set; }
        public int IdTipoBaixa { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public int? IdBordero { get; set; }
        public bool? InAtivo { get; set; }
        public decimal VlBaixa { get; set; }
        public decimal? VlAcrescimos { get; set; }
        public decimal? VlMulta { get; set; }
        public decimal? PrMulta { get; set; }
        public decimal? VlJuros { get; set; }
        public decimal? PrJuros { get; set; }
        public decimal? VlCorrecao { get; set; }
        public decimal? PrCorrecao { get; set; }
        public decimal VlTotalBaixa { get; set; }
        public string TxObservacoes { get; set; }
        public decimal? VlDescontoFaturaFinanceira { get; set; }
        public decimal? PrDescontoFaturaFinanceira { get; set; }
        public int? IdFaturafinanceira { get; set; }
        public int? IdContaReceberCreditoAdiantamento { get; set; }
        public int? IdTipoMulta { get; set; }
        public int? IdTipoJuros { get; set; }
        public int? IdTipoCorrecao { get; set; }
        public decimal? VlDescontos { get; set; }
        public bool InEstornado { get; set; }
        public int? IdTipoMotivoEstorno { get; set; }
        public int? IdParcelacontapagarBaixaEstornada { get; set; }
        public int? IdLancamentoBancarioRestituicao { get; set; }
        public decimal? VlTributosRetidos { get; set; }

        public virtual Bordero IdBorderoNavigation { get; set; }
        public virtual ContaReceber IdContaReceberCreditoAdiantamentoNavigation { get; set; }
        public virtual FaturaFinanceira IdFaturafinanceiraNavigation { get; set; }
        public virtual LancamentoBancario IdLancamentoBancarioRestituicaoNavigation { get; set; }
        public virtual ParcelaContaPagarBaixa IdParcelacontapagarBaixaEstornadaNavigation { get; set; }
        public virtual TipoDiversos IdTipoBaixaNavigation { get; set; }
        public virtual TipoDiversos IdTipoCorrecaoNavigation { get; set; }
        public virtual TipoDiversos IdTipoJurosNavigation { get; set; }
        public virtual TipoDiversos IdTipoMotivoEstornoNavigation { get; set; }
        public virtual TipoDiversos IdTipoMultaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ParcelaContaPagar ParcelaContaPagar { get; set; }
        public virtual ICollection<ContaPagarTributoAliquota> ContaPagarTributoAliquotaIdParcelacontapagarBaixaBaixaNavigation { get; set; }
        public virtual ICollection<ContaPagarTributoAliquota> ContaPagarTributoAliquotaIdParcelacontapagarBaixaOrigemNavigation { get; set; }
        public virtual ICollection<ContaReceber> ContaReceber { get; set; }
        public virtual ICollection<ParcelaContaPagarBaixa> InverseIdParcelacontapagarBaixaEstornadaNavigation { get; set; }
        public virtual ICollection<LancamentoBancario> LancamentoBancario { get; set; }
        public virtual ICollection<ParcelaContaPagarBaixaAcrescimo> ParcelaContaPagarBaixaAcrescimo { get; set; }
        public virtual ICollection<ParcelaContaPagarBaixaContaPagarTributoAliquota> ParcelaContaPagarBaixaContaPagarTributoAliquota { get; set; }
        public virtual ICollection<ParcelaContaPagarBaixaDesconto> ParcelaContaPagarBaixaDesconto { get; set; }
        public virtual ICollection<ParcelaContaReceberBaixa> ParcelaContaReceberBaixa { get; set; }
    }
}