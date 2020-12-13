﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OperadoraRecebimentoParcelaSemConciliacao
    {
        public OperadoraRecebimentoParcelaSemConciliacao()
        {
            ContaReceber = new HashSet<ContaReceber>();
        }

        public int IdOperadorarecebimentoparcelasemconciliacao { get; set; }
        public int IdOperadorarecebimento { get; set; }
        public decimal VlSemconciliacao { get; set; }
        public string TxJustificativa { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public bool? InAtivo { get; set; }
        public int? IdTipoParcela { get; set; }
        public int? IdLancamentoBancario { get; set; }

        public virtual LancamentoBancario IdLancamentoBancarioNavigation { get; set; }
        public virtual OperadoraRecebimento IdOperadorarecebimentoNavigation { get; set; }
        public virtual TipoDiversos IdTipoParcelaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ContaReceber> ContaReceber { get; set; }
    }
}