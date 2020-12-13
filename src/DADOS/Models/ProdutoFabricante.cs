﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProdutoFabricante
    {
        /// <summary>
        /// PK - Identificador de Fabricante. FK com Pessoa.
        /// </summary>
        public int IdFabricante { get; set; }
        /// <summary>
        /// PK - Identificador de Produto. FK com Produto.
        /// </summary>
        public int IdProduto { get; set; }
        /// <summary>
        /// Indentificador de que tipo o produto se enquadra. Ex: Genérico ou Similar. Associação com TipoDiversos.
        /// 
        /// </summary>
        public int? IdProdutoTipo { get; set; }
        /// <summary>
        /// Nome comercial do produto.
        /// 
        /// </summary>
        public string NmComercial { get; set; }
        /// <summary>
        /// Numero do Registro do Produto cadastrado na ANVISA
        /// </summary>
        public long? NrRegistroAnvisa { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool InAtivo { get; set; }

        public virtual Pessoa IdFabricanteNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
        public virtual TipoDiversos IdProdutoTipoNavigation { get; set; }
    }
}