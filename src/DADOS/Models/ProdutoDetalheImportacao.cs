﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProdutoDetalheImportacao
    {
        public int IdProdutoDetalhe { get; set; }
        public int IdProduto { get; set; }
        public string TxComplemento { get; set; }
        public bool? InBaseKit { get; set; }
        public bool InPadronizado { get; set; }
        public bool InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int? QnConsumoMinimo { get; set; }
        public int? IdMdConsumoMinimo { get; set; }
        public int? IdMdCompra { get; set; }
    }
}