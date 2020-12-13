﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Mensagem
    {
        public Mensagem()
        {
            MensagemNovoControle = new HashSet<MensagemNovoControle>();
            MensagemPerfil = new HashSet<MensagemPerfil>();
            MensagemSolicitacao = new HashSet<MensagemSolicitacao>();
            MensagemUnidadeOrganizacional = new HashSet<MensagemUnidadeOrganizacional>();
            MensagemUsuario = new HashSet<MensagemUsuario>();
        }

        public int IdMensagem { get; set; }
        public int IdUsuarioRemetente { get; set; }
        public int IdStatusMensagem { get; set; }
        public int IdTipoMensagem { get; set; }
        public int? IdMensagemPai { get; set; }
        public string TxAssunto { get; set; }
        public DateTime? DtEnvioMensagem { get; set; }
        public DateTime? DtValidadeMensagem { get; set; }
        public bool? InAceito { get; set; }
        public string HtmlMensagem { get; set; }

        public virtual TipoDiversos IdStatusMensagemNavigation { get; set; }
        public virtual MensagemTipo IdTipoMensagemNavigation { get; set; }
        public virtual Usuario IdUsuarioRemetenteNavigation { get; set; }
        public virtual ICollection<MensagemNovoControle> MensagemNovoControle { get; set; }
        public virtual ICollection<MensagemPerfil> MensagemPerfil { get; set; }
        public virtual ICollection<MensagemSolicitacao> MensagemSolicitacao { get; set; }
        public virtual ICollection<MensagemUnidadeOrganizacional> MensagemUnidadeOrganizacional { get; set; }
        public virtual ICollection<MensagemUsuario> MensagemUsuario { get; set; }
    }
}