﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ListaMedicamentoResumida
    {
        public int IdProduto { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public string TxDescricao { get; set; }
        public int? QnConsumoMinimo { get; set; }
        public int? IdMdConsumoMinimo { get; set; }
        public bool InAtivo { get; set; }
    }
}