﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProdutoDetalheInstrucaoEspecial
    {
        public int IdProdutoDetalhe { get; set; }
        public int IdInstrucaoEspecial { get; set; }

        public virtual TipoDiversos IdInstrucaoEspecialNavigation { get; set; }
        public virtual ProdutoDetalhe IdProdutoDetalheNavigation { get; set; }
    }
}