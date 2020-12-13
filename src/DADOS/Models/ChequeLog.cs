﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ChequeLog
    {
        public int IdChequeLog { get; set; }
        public int IdCheque { get; set; }
        public int IdContaBancaria { get; set; }
        public int NrCheque { get; set; }
        public int IdFavorecido { get; set; }
        public DateTime DtEmissao { get; set; }
        public bool InCompensado { get; set; }
        public decimal VlCheque { get; set; }
        public bool InCancelado { get; set; }
        public string TxMotivoCancelamento { get; set; }
        public int IdUsuarioEmitiu { get; set; }
        public int? IdUsuarioCancelou { get; set; }
        public int? IdBordero { get; set; }
        public int? IdSerie { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioOperacao { get; set; }
        public DateTime DtCadastro { get; set; }

        public virtual Usuario IdUsuarioOperacaoNavigation { get; set; }
    }
}