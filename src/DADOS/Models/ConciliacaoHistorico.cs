﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ConciliacaoHistorico
    {
        public string NrLancamento { get; set; }
        public int IdContaCobrancaComplementoHistorico { get; set; }
        public int? IdLote { get; set; }
        public int IdConta { get; set; }
        public int IdAtendimento { get; set; }
        public string NmOperadora { get; set; }
        public string NmPaciente { get; set; }
        public decimal? VlTotalPago { get; set; }
        public decimal? VlFaturado { get; set; }
        public bool InExcluido { get; set; }
        public string InEnviada { get; set; }
        public DateTime? DtBaixaConvenio { get; set; }
        public int IdUsuario { get; set; }
        public string TxLogin { get; set; }
        public string TxObservacao { get; set; }
        public int? IdCartarecurso { get; set; }
        public int IdLancamentoBancario { get; set; }
        public int? IdFaturamentobaixagrupo { get; set; }
        public string TxTipoBaixa { get; set; }
        public decimal VlAcrescimos { get; set; }
        public decimal VlDesconto { get; set; }
        public decimal VlLiqRecebSemAcresc { get; set; }
        public decimal VlReversao { get; set; }
        public int? IdTipoBaixa { get; set; }
    }
}