﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ParcelaContaPagarLog
    {
        public int IdParcelaContaPagarLog { get; set; }
        public int IdContaPagar { get; set; }
        public int NrParcela { get; set; }
        public DateTime DtVencimento { get; set; }
        public double VlParcela { get; set; }
        public int IdStatus { get; set; }
        public double? VlPago { get; set; }
        public int? IdCheque { get; set; }
        public int? IdBordero { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioOperacao { get; set; }
        public decimal? VlAcrescimos { get; set; }
        public decimal? VlDescontos { get; set; }
        public decimal? VlPagar { get; set; }

        public virtual Usuario IdUsuarioOperacaoNavigation { get; set; }
    }
}