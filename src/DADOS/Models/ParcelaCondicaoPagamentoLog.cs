﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ParcelaCondicaoPagamentoLog
    {
        public int IdCondicaoPagamentoLog { get; set; }
        public int IdCondicaoPagamento { get; set; }
        public int NrParcela { get; set; }
        public int NrDias { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioOperacao { get; set; }

        public virtual Usuario IdUsuarioOperacaoNavigation { get; set; }
    }
}