﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ParcelaContaReceberBaixa
    {
        public ParcelaContaReceberBaixa()
        {
            ContaCorrente = new HashSet<ContaCorrente>();
            InverseIdParcelacontareceberBaixaEstornadaNavigation = new HashSet<ParcelaContaReceberBaixa>();
            ParcelaContaReceberBaixaAcrescimo = new HashSet<ParcelaContaReceberBaixaAcrescimo>();
            ParcelaContaReceberBaixaDesconto = new HashSet<ParcelaContaReceberBaixaDesconto>();
        }

        public int IdParcelacontareceberBaixa { get; set; }
        public int? IdFaturamentobaixagrupo { get; set; }
        public int IdTipoBaixa { get; set; }
        public int IdContaReceber { get; set; }
        public int NrParcela { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime DtBaixa { get; set; }
        public decimal VlBaixa { get; set; }
        public decimal? VlAcrescimos { get; set; }
        public decimal? VlMulta { get; set; }
        public decimal? VlJuros { get; set; }
        public decimal? VlCorrecao { get; set; }
        public decimal? VlDesconto { get; set; }
        public decimal? VlTotalBaixa { get; set; }
        public int? IdImpostoRetido { get; set; }
        public decimal? VlImpostoRetido { get; set; }
        public string TxObservacoes { get; set; }
        public bool? InAtivo { get; set; }
        public int IdUsuario { get; set; }
        public int? IdTipoDocumento { get; set; }
        public int? NrDocumento { get; set; }
        public int? IdLancamentoBancario { get; set; }
        public int? IdLancamentoBancarioEstorno { get; set; }
        public int? IdNotaEmitida { get; set; }
        public int? IdCaixamovimento { get; set; }
        public int? IdParcelacontapagarBaixa { get; set; }
        public decimal? VlDiferencaAMaior { get; set; }
        public int? IdContaPagarCreditoAdiantamento { get; set; }
        public int? IdParcelacontareceberBaixaEstornada { get; set; }
        public int? IdNotaemitidaFormapagamento { get; set; }
        public int? IdContaCorrente { get; set; }
        public int? IdFaturafinanceira { get; set; }
        public int? IdTipoMulta { get; set; }
        public decimal? PrMulta { get; set; }
        public int? IdTipoJuros { get; set; }
        public decimal? PrJuros { get; set; }
        public int? IdTipoCorrecao { get; set; }
        public decimal? PrCorrecao { get; set; }
        public decimal? VlDescontos { get; set; }
        public bool InPendenteMeioDePagto { get; set; }
        public decimal? VlTributosRetidos { get; set; }
        public bool InEstornado { get; set; }
        public int? IdTipoMotivoEstorno { get; set; }
        public DateTime? DtReferenciaCalculos { get; set; }

        public virtual CaixaMovimento IdCaixamovimentoNavigation { get; set; }
        public virtual ContaCorrente IdContaCorrenteNavigation { get; set; }
        public virtual ContaPagar IdContaPagarCreditoAdiantamentoNavigation { get; set; }
        public virtual FaturaFinanceira IdFaturafinanceiraNavigation { get; set; }
        public virtual FaturamentoBaixaGrupo IdFaturamentobaixagrupoNavigation { get; set; }
        public virtual ImpostoRetido IdImpostoRetidoNavigation { get; set; }
        public virtual LancamentoBancario IdLancamentoBancarioEstornoNavigation { get; set; }
        public virtual LancamentoBancario IdLancamentoBancarioNavigation { get; set; }
        public virtual NotaEmitida IdNotaEmitidaNavigation { get; set; }
        public virtual NotaEmitidaFormaPagamento IdNotaemitidaFormapagamentoNavigation { get; set; }
        public virtual ParcelaContaPagarBaixa IdParcelacontapagarBaixaNavigation { get; set; }
        public virtual ParcelaContaReceberBaixa IdParcelacontareceberBaixaEstornadaNavigation { get; set; }
        public virtual TipoDiversos IdTipoBaixaNavigation { get; set; }
        public virtual TipoDiversos IdTipoCorrecaoNavigation { get; set; }
        public virtual TipoDocumento IdTipoDocumentoNavigation { get; set; }
        public virtual TipoDiversos IdTipoJurosNavigation { get; set; }
        public virtual TipoDiversos IdTipoMotivoEstornoNavigation { get; set; }
        public virtual TipoDiversos IdTipoMultaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ParcelaContaReceber ParcelaContaReceber { get; set; }
        public virtual ICollection<ContaCorrente> ContaCorrente { get; set; }
        public virtual ICollection<ParcelaContaReceberBaixa> InverseIdParcelacontareceberBaixaEstornadaNavigation { get; set; }
        public virtual ICollection<ParcelaContaReceberBaixaAcrescimo> ParcelaContaReceberBaixaAcrescimo { get; set; }
        public virtual ICollection<ParcelaContaReceberBaixaDesconto> ParcelaContaReceberBaixaDesconto { get; set; }
    }
}