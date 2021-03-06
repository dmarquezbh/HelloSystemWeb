﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class AtendimentoLeito
    {
        public int IdAtendimento { get; set; }
        public int IdLeito { get; set; }
        public DateTime DtOcupacao { get; set; }
        public DateTime? DtDesocupacao { get; set; }
        public int? IdMotivoUpgrade { get; set; }
        public bool? InLeitoAtual { get; set; }
        public int? IdTipoLeitoCobrado { get; set; }
        public int? IdMotivoMovimentacao { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        /// <summary>
        /// armazena o usuário que realizou a movimentação
        /// </summary>
        public int? IdUsuario { get; set; }

        public virtual Atendimento IdAtendimentoNavigation { get; set; }
        public virtual Leito IdLeitoNavigation { get; set; }
        public virtual TipoDiversos IdMotivoMovimentacaoNavigation { get; set; }
        public virtual TipoDiversos IdMotivoUpgradeNavigation { get; set; }
        public virtual TipoDiversos IdTipoLeitoCobradoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}