﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class EstoqueLocalizaHistorico
    {
        public int IdEstoqueLocalizaHistorico { get; set; }
        public int IdUnidadeOrganizacional { get; set; }
        public int IdFabricante { get; set; }
        public int IdFabricantePrioridade { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public int QnProduto { get; set; }
        public int QnProdutoAnterior { get; set; }
        public int SaldoProdutoUnidade { get; set; }
        public int QnConsignado { get; set; }
        public int QnConsignadoAnterior { get; set; }
        public int SaldoConsignadoUnidade { get; set; }
        public DateTime DtOcorrencia { get; set; }
        public int IdUsuario { get; set; }
        public DateTime? DtRegistroEstoque { get; set; }
        public bool? InKit { get; set; }
    }
}