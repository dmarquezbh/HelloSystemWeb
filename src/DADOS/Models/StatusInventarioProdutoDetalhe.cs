﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class StatusInventarioProdutoDetalhe
    {
        public StatusInventarioProdutoDetalhe()
        {
            InventarioProdutoDetalhe = new HashSet<InventarioProdutoDetalhe>();
        }

        public int IdStatusContagemProdutoDetalhe { get; set; }
        public string NmStatusContagemProdutoDetalhe { get; set; }

        public virtual ICollection<InventarioProdutoDetalhe> InventarioProdutoDetalhe { get; set; }
    }
}