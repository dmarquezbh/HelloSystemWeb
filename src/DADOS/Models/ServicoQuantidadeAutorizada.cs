﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ServicoQuantidadeAutorizada
    {
        public int IdServicoQtdeAutorizada { get; set; }
        public int IdOperadora { get; set; }
        public int IdServico { get; set; }
        public int IdFatorAplicacao { get; set; }
        public int QnServico { get; set; }
        public int QnPeriodo { get; set; }
        public int IdUnidadeMedida { get; set; }
        public int? IdPlano { get; set; }
        public int? IdUnidadeOrganizacional { get; set; }
        public bool? InLancarComplemento { get; set; }
        public bool? InExcedenteNaoCobrado { get; set; }
        public bool? InAtivo { get; set; }
        public DateTime? DtInicio { get; set; }
        public int? IdUsuarioDtInicio { get; set; }
        public DateTime? DtFinal { get; set; }
        public int? IdUsuarioDtFinal { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual TipoDiversos IdFatorAplicacaoNavigation { get; set; }
        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual Plano IdPlanoNavigation { get; set; }
        public virtual Servico IdServicoNavigation { get; set; }
        public virtual TipoDiversos IdUnidadeMedidaNavigation { get; set; }
        public virtual UnidadeOrganizacional IdUnidadeOrganizacionalNavigation { get; set; }
        public virtual Usuario IdUsuarioDtFinalNavigation { get; set; }
        public virtual Usuario IdUsuarioDtInicioNavigation { get; set; }
    }
}