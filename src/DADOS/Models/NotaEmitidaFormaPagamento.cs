﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class NotaEmitidaFormaPagamento
    {
        public NotaEmitidaFormaPagamento()
        {
            LancamentoBancario = new HashSet<LancamentoBancario>();
            ParcelaContaReceberBaixa = new HashSet<ParcelaContaReceberBaixa>();
        }

        public int IdNotaEmitida { get; set; }
        public int IdFormaPagamento { get; set; }
        public DateTime DtPagamento { get; set; }
        public decimal VlPagamento { get; set; }
        public string TxBandeira { get; set; }
        public string TxNrcartao { get; set; }
        public string TxNrautorizacao { get; set; }
        public string TxBanco { get; set; }
        public string TxAgencia { get; set; }
        public string TxContacorrente { get; set; }
        public string TxNrcheque { get; set; }
        public string TxRegistro { get; set; }
        public string TxParcelas { get; set; }
        public string TxDebitocredito { get; set; }
        public int IdNotaemitidaFormapagamento { get; set; }
        public int? IdLancamentoBancario { get; set; }
        public int? IdLancamentoBancarioVinculado { get; set; }
        public string NmResponsavel { get; set; }
        public string NrCpfCnpjResponsavel { get; set; }
        public int? IdContaBancaria { get; set; }

        public virtual ContaBancaria IdContaBancariaNavigation { get; set; }
        public virtual FormaPagamento IdFormaPagamentoNavigation { get; set; }
        public virtual LancamentoBancario IdLancamentoBancarioVinculadoNavigation { get; set; }
        public virtual NotaEmitida IdNotaEmitidaNavigation { get; set; }
        public virtual ICollection<LancamentoBancario> LancamentoBancario { get; set; }
        public virtual ICollection<ParcelaContaReceberBaixa> ParcelaContaReceberBaixa { get; set; }
    }
}