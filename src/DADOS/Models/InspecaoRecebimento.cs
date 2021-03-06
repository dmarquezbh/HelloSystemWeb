﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class InspecaoRecebimento
    {
        public InspecaoRecebimento()
        {
            InspecaoRecebimentoOrdemCompra = new HashSet<InspecaoRecebimentoOrdemCompra>();
            InspecaoRecebimentoParametroAvaliacao = new HashSet<InspecaoRecebimentoParametroAvaliacao>();
        }

        public int IdInspecaoRecebimento { get; set; }
        public DateTime DtRecebimento { get; set; }
        public int IdFornecedor { get; set; }
        public long? NrNotaFiscal { get; set; }
        public string NmTransportadora { get; set; }
        public int? IdTipoNotaEntrada { get; set; }
        public int IdTipoEntrega { get; set; }
        public DateTime? DtDevolucao { get; set; }
        public DateTime? DtRecolhimento { get; set; }
        public string TxObservacao { get; set; }
        public DateTime DtCadastro { get; set; }
        public int IdUsuario { get; set; }
        public bool InAtivo { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioExcluiu { get; set; }

        public virtual Pessoa IdFornecedorNavigation { get; set; }
        public virtual TipoDiversos IdTipoEntregaNavigation { get; set; }
        public virtual TipoDiversos IdTipoNotaEntradaNavigation { get; set; }
        public virtual Usuario IdUsuarioExcluiuNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<InspecaoRecebimentoOrdemCompra> InspecaoRecebimentoOrdemCompra { get; set; }
        public virtual ICollection<InspecaoRecebimentoParametroAvaliacao> InspecaoRecebimentoParametroAvaliacao { get; set; }
    }
}