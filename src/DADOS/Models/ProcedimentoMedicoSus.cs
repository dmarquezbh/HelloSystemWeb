﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ProcedimentoMedicoSus
    {
        public int IdOperadora { get; set; }
        public int IdServicoProdutoTabela { get; set; }
        public int IdServico { get; set; }
        public int? CdServico { get; set; }
        public string TxDescricao { get; set; }
        public int IdServicoReferencia { get; set; }
        public int? CdServicoReferencia { get; set; }
        public string TxDescricaoReferencia { get; set; }
        public bool InAtivo { get; set; }
    }
}