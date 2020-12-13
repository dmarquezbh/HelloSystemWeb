﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class FormaPagamento
    {
        public FormaPagamento()
        {
            Bordero = new HashSet<Bordero>();
            NotaEmitidaFormaPagamento = new HashSet<NotaEmitidaFormaPagamento>();
        }

        /// <summary>
        /// Identificador da forma de recebimento de uma nota fiscal emitida pelo sistema 
        /// </summary>
        public int IdFormaPagamento { get; set; }
        /// <summary>
        /// Descrição da forma de recebimento de uma nota fiscal emitida pelo sistema 
        /// </summary>
        public string NmFormaPagamento { get; set; }
        /// <summary>
        /// Indicador de forma de recebimento de uma nota fiscal emitida ativa ou excluída logicamente 
        /// </summary>
        public bool? InAtivo { get; set; }
        /// <summary>
        /// Identificador do tipo da forma de pagamento (cartão de crédito, dinheiro, etc.)
        /// </summary>
        public int? IdTipoFormaPagamento { get; set; }

        public virtual TipoDiversos IdTipoFormaPagamentoNavigation { get; set; }
        public virtual ICollection<Bordero> Bordero { get; set; }
        public virtual ICollection<NotaEmitidaFormaPagamento> NotaEmitidaFormaPagamento { get; set; }
    }
}