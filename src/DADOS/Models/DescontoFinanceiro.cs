﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class DescontoFinanceiro
    {
        public int IdNotaEntrada { get; set; }
        public bool InPercentual { get; set; }
        public decimal? PrDesconto { get; set; }
        public decimal? VlDesconto { get; set; }

        public virtual NotaEntrada IdNotaEntradaNavigation { get; set; }
    }
}