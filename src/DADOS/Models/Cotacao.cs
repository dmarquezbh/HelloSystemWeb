﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Cotacao
    {
        public Cotacao()
        {
            CotacaoFornecedor = new HashSet<CotacaoFornecedor>();
            CotacaoProduto = new HashSet<CotacaoProduto>();
            CotacaoProdutoDetalhe = new HashSet<CotacaoProdutoDetalhe>();
            ImportacaoBionexo = new HashSet<ImportacaoBionexo>();
        }

        /// <summary>
        /// PK da Tabela. Identificador único.
        /// </summary>
        public int IdCotacao { get; set; }
        /// <summary>
        /// Data de Abertura da Cotação
        /// 
        /// </summary>
        public DateTime? DtInicio { get; set; }
        /// <summary>
        /// Data de encerramento da Cotação.
        /// 
        /// </summary>
        public DateTime? DtEncerramento { get; set; }
        /// <summary>
        /// Status da Cotação. FK com TipoDiversos.
        /// 
        /// </summary>
        public int? IdStatusCotacao { get; set; }
        /// <summary>
        /// Comprador (funcionario do Hospital) que abriu a cotação no Hospitale.
        /// 
        /// </summary>
        public int? IdComprador { get; set; }
        /// <summary>
        /// Data da criação da cotação no sistema. (getdate)
        /// 
        /// </summary>
        public DateTime? DtCotacao { get; set; }
        public bool? InComplementar { get; set; }
        public bool? InContrato { get; set; }

        public virtual Pessoa IdCompradorNavigation { get; set; }
        public virtual TipoDiversos IdStatusCotacaoNavigation { get; set; }
        public virtual ICollection<CotacaoFornecedor> CotacaoFornecedor { get; set; }
        public virtual ICollection<CotacaoProduto> CotacaoProduto { get; set; }
        public virtual ICollection<CotacaoProdutoDetalhe> CotacaoProdutoDetalhe { get; set; }
        public virtual ICollection<ImportacaoBionexo> ImportacaoBionexo { get; set; }
    }
}