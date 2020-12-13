﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class EmbalagemProdutoDetalhe
    {
        public EmbalagemProdutoDetalhe()
        {
            LoteProduto = new HashSet<LoteProduto>();
        }

        /// <summary>
        /// PK da Tabela. FK com ProdutoDetalhe_Fabricante. Representao Produto Detalhe
        /// </summary>
        public int IdProdutoDetalhe { get; set; }
        /// <summary>
        /// PK da Tabela. FK com ProdutoDetalhe_Fabricante. Reprenta o Fabricante do Produto Detalhe.
        /// 
        /// </summary>
        public int IdFabricante { get; set; }
        /// <summary>
        /// PK da Tabela. FK com Embalagem_Embalagem. Representa a Embalagem Pai.
        /// </summary>
        public int IdEmbalagemPai { get; set; }
        /// <summary>
        /// PK da Tabela. FK com Embalagem_Embalagem. Representa a Embalagem Filho.
        /// 
        /// </summary>
        public int IdEmbalagemFilho { get; set; }

        public virtual ProdutoDetalheFabricante Id { get; set; }
        public virtual EmbalagemEmbalagem IdEmbalagem { get; set; }
        public virtual ICollection<LoteProduto> LoteProduto { get; set; }
    }
}