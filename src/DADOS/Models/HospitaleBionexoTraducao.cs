﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class HospitaleBionexoTraducao
    {
        public int IdProdutoDetalhe { get; set; }
        public string IdProdutoBionexo { get; set; }

        public virtual ProdutoDetalhe IdProdutoDetalheNavigation { get; set; }
    }
}