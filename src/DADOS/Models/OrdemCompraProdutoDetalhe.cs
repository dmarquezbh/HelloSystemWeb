﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OrdemCompraProdutoDetalhe
    {
        /// <summary>
        /// PK da tabela. FK com OrdemCompra.
        /// </summary>
        public int IdOrdemCompra { get; set; }
        /// <summary>
        /// PK da tabela. FK com ProdutoDetalhe_Fabricante.
        /// </summary>
        public int IdProdutoDetalhe { get; set; }
        /// <summary>
        /// PK da Tabela. FK com ProdutoDetalhe_Fabricante
        /// 
        /// </summary>
        public int IdFabricante { get; set; }
        /// <summary>
        /// Valor unitário do Produto.
        /// 
        /// </summary>
        public decimal? VlUnitarioProduto { get; set; }
        /// <summary>
        /// Quantidade do produto.
        /// </summary>
        public int? QnProduto { get; set; }
        /// <summary>
        /// Valor do IPI.
        /// 
        /// </summary>
        public decimal? VlIpi { get; set; }
        /// <summary>
        /// Valor do ICMS.
        /// 
        /// </summary>
        public decimal? VlIcms { get; set; }
        /// <summary>
        /// Valor de desconto.
        /// </summary>
        public decimal? VlDesconto { get; set; }
        /// <summary>
        /// Valor total do produto.
        /// </summary>
        public decimal? VlTotal { get; set; }
        /// <summary>
        /// ID da Embalagem associada ao produto. FK com Embalagem.
        /// 
        /// </summary>
        public int? IdEmbalagem { get; set; }
        /// <summary>
        /// Quantidade entregue do produto.
        /// </summary>
        public int? QnProdutoEntregue { get; set; }
        /// <summary>
        /// ICMS em percentual.
        /// </summary>
        public decimal? PrIcms { get; set; }
        /// <summary>
        /// IPI em percentual.
        /// </summary>
        public decimal? PrIpi { get; set; }
        /// <summary>
        /// Desconto em percentual.
        /// 
        /// </summary>
        public decimal? PrDesconto { get; set; }
        /// <summary>
        /// Flag para indicar se é uma boa compra.
        /// </summary>
        public string InBoaCompra { get; set; }
        /// <summary>
        /// Flag que informa se foi a ultima compra do produto.
        /// </summary>
        public bool? InUltimaCompra { get; set; }
        public bool InEntregaConcluida { get; set; }

        public virtual ProdutoDetalheFabricante Id { get; set; }
        public virtual Embalagem IdEmbalagemNavigation { get; set; }
        public virtual OrdemCompra IdOrdemCompraNavigation { get; set; }
    }
}