﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class FaturamentoIndevido
    {
        public int IdConta { get; set; }
        public int IdFechamentoItem { get; set; }
        public double? VlFi { get; set; }
        public double? QnFi { get; set; }
        public string IdJustificativa { get; set; }
        public string TxObservacoes { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public int IdUsuario { get; set; }
        public int? IdUnidadeOrganizacionalAuditoria { get; set; }
        public DateTime? DtFaturamentoIndevido { get; set; }
        public int? IdMovimentacaocontaparcelabaixada { get; set; }
        public bool InBaixouContaReceber { get; set; }
        public bool InPreparandoContaLimpa { get; set; }
        public int? IdFaturamentobaixagrupo { get; set; }

        public virtual FechamentoItem Id { get; set; }
        public virtual FaturamentoBaixaGrupo IdFaturamentobaixagrupoNavigation { get; set; }
        public virtual JustificativaGlosaFi IdJustificativaNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}