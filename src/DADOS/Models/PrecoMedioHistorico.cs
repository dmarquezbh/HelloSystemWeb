﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PrecoMedioHistorico
    {
        public int IdPrecoMedioHistorico { get; set; }
        public int IdPrecoMedio { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public int? IdFabricante { get; set; }
        public DateTime DtInventario { get; set; }
        public int? QnProduto { get; set; }
        public decimal VlPrecoMedio { get; set; }
        public decimal? PrVariacao { get; set; }
        public int? IdNotaEntrada { get; set; }
        public DateTime DtCadastro { get; set; }

        public virtual ProdutoDetalheFabricante Id { get; set; }
    }
}