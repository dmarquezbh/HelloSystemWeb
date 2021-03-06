﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Perfil
    {
        public Perfil()
        {
            ContaBancariaPerfil = new HashSet<ContaBancariaPerfil>();
            InverseIdPerfilBaseNavigation = new HashSet<Perfil>();
            MensagemPerfil = new HashSet<MensagemPerfil>();
            MensagemPerfilEnvioPerfilIdPerfilDestinatarioNavigation = new HashSet<MensagemPerfilEnvioPerfil>();
            MensagemPerfilEnvioPerfilIdPerfilRemetenteNavigation = new HashSet<MensagemPerfilEnvioPerfil>();
            MensagemTipoPerfil = new HashSet<MensagemTipoPerfil>();
            PerfilClassificacaoProduto = new HashSet<PerfilClassificacaoProduto>();
            PerfilUnidadeOrganizacional = new HashSet<PerfilUnidadeOrganizacional>();
            PerfilUsuario = new HashSet<PerfilUsuario>();
            PermissaoPerfilControle = new HashSet<PermissaoPerfilControle>();
            RegistroEletronicoItemModeloAtributoPerfil = new HashSet<RegistroEletronicoItemModeloAtributoPerfil>();
            TipoContaReceberPerfil = new HashSet<TipoContaReceberPerfil>();
        }

        public int IdPerfil { get; set; }
        public string NmPerfil { get; set; }
        public string TxDescricao { get; set; }
        public int IdPerfilTipo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int? IdPerfilBase { get; set; }
        public int IdAbrangenciaTipo { get; set; }
        public int? NrDiasExpiraSenha { get; set; }

        public virtual TipoDiversos IdAbrangenciaTipoNavigation { get; set; }
        public virtual Perfil IdPerfilBaseNavigation { get; set; }
        public virtual TipoDiversos IdPerfilTipoNavigation { get; set; }
        public virtual ICollection<ContaBancariaPerfil> ContaBancariaPerfil { get; set; }
        public virtual ICollection<Perfil> InverseIdPerfilBaseNavigation { get; set; }
        public virtual ICollection<MensagemPerfil> MensagemPerfil { get; set; }
        public virtual ICollection<MensagemPerfilEnvioPerfil> MensagemPerfilEnvioPerfilIdPerfilDestinatarioNavigation { get; set; }
        public virtual ICollection<MensagemPerfilEnvioPerfil> MensagemPerfilEnvioPerfilIdPerfilRemetenteNavigation { get; set; }
        public virtual ICollection<MensagemTipoPerfil> MensagemTipoPerfil { get; set; }
        public virtual ICollection<PerfilClassificacaoProduto> PerfilClassificacaoProduto { get; set; }
        public virtual ICollection<PerfilUnidadeOrganizacional> PerfilUnidadeOrganizacional { get; set; }
        public virtual ICollection<PerfilUsuario> PerfilUsuario { get; set; }
        public virtual ICollection<PermissaoPerfilControle> PermissaoPerfilControle { get; set; }
        public virtual ICollection<RegistroEletronicoItemModeloAtributoPerfil> RegistroEletronicoItemModeloAtributoPerfil { get; set; }
        public virtual ICollection<TipoContaReceberPerfil> TipoContaReceberPerfil { get; set; }
    }
}