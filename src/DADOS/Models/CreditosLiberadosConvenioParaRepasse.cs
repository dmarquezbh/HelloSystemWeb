﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CreditosLiberadosConvenioParaRepasse
    {
        public string NmOperadora { get; set; }
        public int IdLancamentoBancario { get; set; }
        public int IdNotaEmitida { get; set; }
        public int? IdLote { get; set; }
        public double VlLancamento { get; set; }
        public DateTime? DtConciliacao { get; set; }
        public decimal? VlConciliado { get; set; }
        public double? VlGlosas { get; set; }
        public double? VlLote { get; set; }
    }
}