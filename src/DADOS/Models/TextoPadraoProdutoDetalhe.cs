﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TextoPadraoProdutoDetalhe
    {
        public int IdTextoPadraoProdutoDetalhe { get; set; }
        public int IdTextoPadrao { get; set; }
        public int IdProdutoDetalhe { get; set; }

        public virtual ProdutoDetalhe IdProdutoDetalheNavigation { get; set; }
        public virtual TextoPadrao IdTextoPadraoNavigation { get; set; }
    }
}