﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class NotaEntrada
    {
        public NotaEntrada()
        {
            AntecipacaoEntregaProduto = new HashSet<AntecipacaoEntregaProduto>();
            ConsignadoPendenteNota = new HashSet<ConsignadoPendenteNota>();
            ContaPagar = new HashSet<ContaPagar>();
            NotaEntradaHistorico = new HashSet<NotaEntradaHistorico>();
            NotaEntradaProdutoDetalhe = new HashSet<NotaEntradaProdutoDetalhe>();
            OrdemCompraNotaEntrada = new HashSet<OrdemCompraNotaEntrada>();
            RecusaMaterial = new HashSet<RecusaMaterial>();
        }

        public int IdNotaEntrada { get; set; }
        public int IdTipoNota { get; set; }
        public long? NrNotaFiscal { get; set; }
        public string NmSerie { get; set; }
        public int IdFornecedor { get; set; }
        public DateTime DtEmissao { get; set; }
        public DateTime DtEntrada { get; set; }
        public DateTime DtEntrega { get; set; }
        public decimal VlNotaFiscal { get; set; }
        public decimal? VlDescontoNota { get; set; }
        public decimal? VlFreteNota { get; set; }
        public decimal VlLiquido { get; set; }
        public int? IdTipoCondPagto { get; set; }
        public DateTime DtVencimento { get; set; }
        public int? IdTransportadora { get; set; }
        public int IdStatusNf { get; set; }
        public int? IdOrdemCompra { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int? IdCondicaoPagamento { get; set; }
        public decimal? VlOutrasDespesas { get; set; }
        public int? IdUsuario { get; set; }
        public byte[] ArDocumentoNotaFiscal { get; set; }
        public decimal? VlIsencaoIcms { get; set; }
        public int? IdCentroCusto { get; set; }
        public int? IdUnidadeRecebimento { get; set; }

        public virtual CondicaoPagamento IdCondicaoPagamentoNavigation { get; set; }
        public virtual Pessoa IdFornecedorNavigation { get; set; }
        public virtual OrdemCompra IdOrdemCompraNavigation { get; set; }
        public virtual TipoDiversos IdStatusNfNavigation { get; set; }
        public virtual TipoDiversos IdTipoCondPagtoNavigation { get; set; }
        public virtual TipoDiversos IdTipoNotaNavigation { get; set; }
        public virtual Pessoa IdTransportadoraNavigation { get; set; }
        public virtual DescontoFinanceiro DescontoFinanceiro { get; set; }
        public virtual ICollection<AntecipacaoEntregaProduto> AntecipacaoEntregaProduto { get; set; }
        public virtual ICollection<ConsignadoPendenteNota> ConsignadoPendenteNota { get; set; }
        public virtual ICollection<ContaPagar> ContaPagar { get; set; }
        public virtual ICollection<NotaEntradaHistorico> NotaEntradaHistorico { get; set; }
        public virtual ICollection<NotaEntradaProdutoDetalhe> NotaEntradaProdutoDetalhe { get; set; }
        public virtual ICollection<OrdemCompraNotaEntrada> OrdemCompraNotaEntrada { get; set; }
        public virtual ICollection<RecusaMaterial> RecusaMaterial { get; set; }
    }
}