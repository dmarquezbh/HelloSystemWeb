﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProdutoTraducaoTeste
    {
        public int IdServico { get; set; }
        public int? IdProdutoDetalhe { get; set; }
        public string NmServicoProdutoTabela { get; set; }
        public string CdServico { get; set; }
        public string TxDescricaoServico { get; set; }
        public string NmFabricante { get; set; }
        public string VlPrecoFabricante { get; set; }
        public string VlPrecoConsumidor { get; set; }
        public int InAssociado { get; set; }
        public int IdServicoProdutoTabela { get; set; }
        public bool InDesconto { get; set; }
        public DateTime? DtVigencia { get; set; }
    }
}