﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class DevolucaoChecagem
    {
        public DevolucaoChecagem()
        {
            DevolucaoChecagemSolicitacaoPdEnfermagemHorarioAdministracao = new HashSet<DevolucaoChecagemSolicitacaoPdEnfermagemHorarioAdministracao>();
        }

        public int IdDevolucaoChecagem { get; set; }
        public int IdSolicitacao { get; set; }
        public int IdJustificativa { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtDevolucao { get; set; }

        public virtual TipoDiversos IdJustificativaNavigation { get; set; }
        public virtual Solicitacao IdSolicitacaoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<DevolucaoChecagemSolicitacaoPdEnfermagemHorarioAdministracao> DevolucaoChecagemSolicitacaoPdEnfermagemHorarioAdministracao { get; set; }
    }
}