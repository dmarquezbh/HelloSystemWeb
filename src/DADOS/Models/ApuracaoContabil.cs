﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ApuracaoContabil
    {
        public int IdApuracaoContabil { get; set; }
        public int IdTipoApuracao { get; set; }
        public DateTime DtMinParaOcorrencia { get; set; }
        public DateTime DtCadastro { get; set; }
        public bool? InAtivo { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public DateTime? DtCancelamento { get; set; }
        public bool InCancelado { get; set; }
        public int? IdUsuarioCancelamento { get; set; }

        public virtual TipoDiversos IdTipoApuracaoNavigation { get; set; }
        public virtual Usuario IdUsuarioCadastroNavigation { get; set; }
        public virtual Usuario IdUsuarioCancelamentoNavigation { get; set; }
    }
}