﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class BookProdutividadeFaturamentoReport
    {
        public int IdTipo { get; set; }
        public string TxTipo { get; set; }
        public DateTime DtRegistro { get; set; }
        public string VlParametroUnidadesArquivo { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public int? IdTipoOperadoraSus { get; set; }
        public int? IdOperadora { get; set; }
        public double VlFaturado { get; set; }
        public string TxObservacao { get; set; }
        public double? VlTerceiros { get; set; }
    }
}