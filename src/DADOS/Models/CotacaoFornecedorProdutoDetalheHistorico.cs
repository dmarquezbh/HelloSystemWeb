﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CotacaoFornecedorProdutoDetalheHistorico
    {
        public int IdCotacaoFornecedorProdutodetalheHistorico { get; set; }
        public int IdCotacaoFornecedorProdutodetalhe { get; set; }
        public DateTime? DtCotacao { get; set; }
        public int IdCotacao { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public int IdFornecedor { get; set; }
        public int IdFabricante { get; set; }
        public decimal? VlUnitarioProduto { get; set; }
        public decimal? VlTotalProduto { get; set; }
        public int? QnBonificacao { get; set; }
        public short? PzEntregaProduto { get; set; }
        public DateTime? DtValidade { get; set; }
        public decimal? PrIpi { get; set; }
        public decimal? VlDesconto { get; set; }
        public string TxCondicaoPagamento { get; set; }
        public int? IdEmbalagem { get; set; }
        public decimal? PrIcms { get; set; }
        public decimal? VlFrete { get; set; }
        public decimal? VlUnitarioItem { get; set; }
        public int? IdCondicaoPagamento { get; set; }
        public decimal? VlIcms { get; set; }
        public decimal? VlIpi { get; set; }
        public decimal? PrDesconto { get; set; }
        public int? QnProdutoCotado { get; set; }
        public int? QnEmbalagem { get; set; }
        public DateTime DtHistorico { get; set; }
        public int? QnProdutoComprado { get; set; }
        public decimal? VlTotalComprado { get; set; }
    }
}