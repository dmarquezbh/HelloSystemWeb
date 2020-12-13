﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CotacaoProdutoDetalhe
    {
        /// <summary>
        /// PK da Tabela. FK com Cotacao.
        /// </summary>
        public int IdCotacao { get; set; }
        /// <summary>
        /// PK da tabela. FK com ProdutoDetalhe_Fabricante
        /// 
        /// </summary>
        public int IdProdutoDetalhe { get; set; }
        /// <summary>
        /// PK da Tabela. FK com Solicitacao.
        /// 
        /// </summary>
        public int IdSolicitacao { get; set; }

        public virtual SolicitacaoProdutoDetalhe Id { get; set; }
        public virtual Cotacao IdCotacaoNavigation { get; set; }
    }
}