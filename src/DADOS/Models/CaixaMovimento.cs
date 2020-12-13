﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CaixaMovimento
    {
        public CaixaMovimento()
        {
            ContaCorrente = new HashSet<ContaCorrente>();
            ParcelaContaReceberBaixa = new HashSet<ParcelaContaReceberBaixa>();
        }

        public int IdCaixamovimento { get; set; }
        public int IdCaixa { get; set; }
        public bool InMovimentoAberto { get; set; }
        public decimal VlProvisaoAbertura { get; set; }
        public decimal VlTotalMovimento { get; set; }
        public DateTime DtMovimento { get; set; }
        public DateTime? DtAbertura { get; set; }
        public int IdUsuarioAbertura { get; set; }
        public bool InPermissaoReabertura { get; set; }
        public bool InPermissaoSelecao { get; set; }
        public DateTime? DtFechamento { get; set; }
        public int? IdUsuarioFechamento { get; set; }

        public virtual Caixa IdCaixaNavigation { get; set; }
        public virtual Usuario IdUsuarioAberturaNavigation { get; set; }
        public virtual Usuario IdUsuarioFechamentoNavigation { get; set; }
        public virtual ICollection<ContaCorrente> ContaCorrente { get; set; }
        public virtual ICollection<ParcelaContaReceberBaixa> ParcelaContaReceberBaixa { get; set; }
    }
}