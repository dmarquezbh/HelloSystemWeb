﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProdutoGeralOld
    {
        public int IdProduto { get; set; }
        public int IdProdutoDetalhe { get; set; }
        public int IdFabricante { get; set; }
        public string NmProduto { get; set; }
        public string NmComercial { get; set; }
        public string TxApresentacao { get; set; }
        public bool InAtivo { get; set; }
        public int? IdClassificacaoGeral { get; set; }
        public string NrCodigoBarras { get; set; }
    }
}