﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CotacaoFornecedorProdutoDetalhe
    {
        /// <summary>
        /// PK da Tabela. Identificador único.
        /// </summary>
        public int IdCotacaoFornecedorProdutodetalhe { get; set; }
        /// <summary>
        /// Data da Cotação realizada pelo fornecedor.
        /// 
        /// </summary>
        public DateTime? DtCotacao { get; set; }
        /// <summary>
        /// Referencia de qual cotação se trata. FK com Cotacao.
        /// 
        /// </summary>
        public int IdCotacao { get; set; }
        /// <summary>
        /// Id do produto detalhe. FK com ProdutoDetalhe_Fabricante.
        /// 
        /// </summary>
        public int IdProdutoDetalhe { get; set; }
        /// <summary>
        /// Id do Fornecedor que participa da cotação.
        /// </summary>
        public int IdFornecedor { get; set; }
        /// <summary>
        /// Id do fabricante do produto detalhe cotato.
        /// 
        /// </summary>
        public int IdFabricante { get; set; }
        /// <summary>
        /// Valor unitário do produto no Fornecedor.
        /// 
        /// </summary>
        public decimal? VlUnitarioProduto { get; set; }
        /// <summary>
        /// Valor total do produto detalhe.
        /// </summary>
        public decimal? VlTotalProduto { get; set; }
        /// <summary>
        /// Quantidade de produtos bonificados, ou seja, que não terão custos para o Hospital.
        /// 
        /// </summary>
        public int? QnBonificacao { get; set; }
        /// <summary>
        /// Prazo de entrega do produto. 
        /// </summary>
        public short? PzEntregaProduto { get; set; }
        /// <summary>
        /// Data de Validade da cotação do fornecedor.
        /// 
        /// </summary>
        public DateTime? DtValidade { get; set; }
        /// <summary>
        /// Percentual de IPI no produto.
        /// 
        /// </summary>
        public decimal? PrIpi { get; set; }
        /// <summary>
        /// Valor de desconto no produto.
        /// 
        /// </summary>
        public decimal? VlDesconto { get; set; }
        /// <summary>
        /// Condição de Pagamento.
        /// </summary>
        public string TxCondicaoPagamento { get; set; }
        /// <summary>
        /// Id da embalagem que o produto se enquadra. FK com Embalagem.
        /// 
        /// </summary>
        public int? IdEmbalagem { get; set; }
        /// <summary>
        /// Percentual de ICMS
        /// 
        /// </summary>
        public decimal? PrIcms { get; set; }
        /// <summary>
        /// Valor do Frete.
        /// </summary>
        public decimal? VlFrete { get; set; }
        /// <summary>
        /// Valor unitário do item.
        /// </summary>
        public decimal? VlUnitarioItem { get; set; }
        /// <summary>
        /// Condição de Pagamendo. FK com CondicaoPagamento
        /// 
        /// </summary>
        public int? IdCondicaoPagamento { get; set; }
        /// <summary>
        /// Valor de ICMS
        /// 
        /// </summary>
        public decimal? VlIcms { get; set; }
        /// <summary>
        /// Valor de IPI
        /// 
        /// </summary>
        public decimal? VlIpi { get; set; }
        /// <summary>
        /// Percentual de desconto.
        /// </summary>
        public decimal? PrDesconto { get; set; }
        /// <summary>
        /// Quantidade de produto cotado.
        /// 
        /// </summary>
        public int? QnProdutoCotado { get; set; }
        /// <summary>
        /// Quantidade de Embalagem.
        /// 
        /// </summary>
        public int? QnEmbalagem { get; set; }
        public int? QnProdutoComprado { get; set; }
        public decimal? VlTotalComprado { get; set; }
        public bool? InNaoAtendeContrato { get; set; }
        public string TxJustificativaContrato { get; set; }
        public int? IdSituacaoFiscal { get; set; }

        public virtual CotacaoFornecedor Id { get; set; }
        public virtual CondicaoPagamento IdCondicaoPagamentoNavigation { get; set; }
        public virtual Embalagem IdEmbalagemNavigation { get; set; }
        public virtual ProdutoDetalheFabricante IdNavigation { get; set; }
        public virtual TipoDiversos IdSituacaoFiscalNavigation { get; set; }
        public virtual ResultadoCotacao ResultadoCotacao { get; set; }
    }
}