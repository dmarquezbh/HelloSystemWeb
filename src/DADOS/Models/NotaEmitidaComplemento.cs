﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class NotaEmitidaComplemento
    {
        public int IdNotaEmitida { get; set; }
        public decimal? VlOutrosTributos { get; set; }
        public decimal? VlLiquidoNota { get; set; }
        public int? IdEmpresaPagante { get; set; }
        public string TxObservacao { get; set; }
        public string IdExterno { get; set; }

        public virtual OperadoraEmpresaPagante IdEmpresaPaganteNavigation { get; set; }
        public virtual NotaEmitida IdNotaEmitidaNavigation { get; set; }
    }
}