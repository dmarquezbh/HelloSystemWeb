﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class EmprestimoProdutoDetalhe
    {
        public int NrEmprestimo { get; set; }
        public int IdFabricante { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public DateTime? DtPagamento { get; set; }
        public int? IdEmbalagem { get; set; }
        public int? QnProduto { get; set; }
        public DateTime? DtPrevistaPgto { get; set; }
        public bool? InProdutoEtiquetado { get; set; }
        public string NrLote { get; set; }
        public DateTime? DtValidade { get; set; }

        public virtual ProdutoDetalheFabricante Id { get; set; }
        public virtual Embalagem IdEmbalagemNavigation { get; set; }
        public virtual Emprestimo NrEmprestimoNavigation { get; set; }
    }
}