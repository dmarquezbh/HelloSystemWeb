﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ClinicaIi
    {
        public int IdClinica { get; set; }
        public string NmClinica { get; set; }
        public string TxBanco { get; set; }
        public string TxAgencia { get; set; }
        public string TxContaCorrente { get; set; }
        public bool? InPis { get; set; }
        public bool? InCofins { get; set; }
        public bool? InCsl { get; set; }
        public decimal? NrPercentualParticipacao { get; set; }
        public decimal? NrPercentualIss { get; set; }
        public decimal? PrReembolsoParticular { get; set; }
        public decimal? PrReembolsoConvenio { get; set; }
        public decimal? PrInss { get; set; }
        public decimal? PrInssAdicional { get; set; }
        public bool? InCooperativa { get; set; }
    }
}