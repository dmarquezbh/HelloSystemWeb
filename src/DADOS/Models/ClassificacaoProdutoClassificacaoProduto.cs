﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ClassificacaoProdutoClassificacaoProduto
    {
        /// <summary>
        /// PK da Tabela. FK com ClassificaoProduto. Refere-se a Classificação Pai de um outra Classificação.
        /// </summary>
        public int IdClassificacaoPai { get; set; }
        /// <summary>
        /// PK da Tabela. FK com ClassificaoProduto. Refere-se a Classificação filha de um outra Classificação.
        /// 
        /// </summary>
        public int IdClassificacaoFilho { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool? InUltimoNivel { get; set; }

        public virtual ClassificacaoProduto IdClassificacaoFilhoNavigation { get; set; }
        public virtual ClassificacaoProduto IdClassificacaoPaiNavigation { get; set; }
    }
}