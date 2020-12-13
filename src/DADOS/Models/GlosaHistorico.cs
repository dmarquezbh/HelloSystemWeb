﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class GlosaHistorico
    {
        public int IdGlosaHistorico { get; set; }
        public int IdConta { get; set; }
        public int IdFechamentoItem { get; set; }
        public double? VlGlosado { get; set; }
        public double? QnGlosada { get; set; }
        public string IdJustificativa { get; set; }
        public string TxObservacoes { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public int IdUsuario { get; set; }
        public bool? InAdministrativa { get; set; }
        public int? IdUnidadeOrganizacionalAuditoria { get; set; }
        public DateTime? DtGlosa { get; set; }
        public int? NrOrigemUnimed { get; set; }
        public bool? InAtivo { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public DateTime? DtExclusao { get; set; }
        public int? IdUsuarioOperacao { get; set; }
        public bool InPreparandoContaLimpa { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual Usuario IdUsuarioOperacaoNavigation { get; set; }
    }
}