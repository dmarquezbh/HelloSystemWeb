﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PessoaEntidade
    {
        public PessoaEntidade()
        {
            Documento = new HashSet<Documento>();
            ExamePessoaEntidade = new HashSet<ExamePessoaEntidade>();
            LaboratorioPedido = new HashSet<LaboratorioPedido>();
            PessoaCaracteristicaHistorico = new HashSet<PessoaCaracteristicaHistorico>();
            PessoaEntidadePessoaAtributo = new HashSet<PessoaEntidadePessoaAtributo>();
            PessoaEntidadePessoaEntidadeIdPessoaEntidadeFilhoNavigation = new HashSet<PessoaEntidadePessoaEntidade>();
            PessoaEntidadePessoaEntidadeIdPessoaEntidadePaiNavigation = new HashSet<PessoaEntidadePessoaEntidade>();
            RegistroEletronicoItemModeloAtributoPessoaEntidade = new HashSet<RegistroEletronicoItemModeloAtributoPessoaEntidade>();
            RegistroEletronicoModeloPessoaEntidade = new HashSet<RegistroEletronicoModeloPessoaEntidade>();
            RegistroEletronicoTipoPessoaEntidade = new HashSet<RegistroEletronicoTipoPessoaEntidade>();
            Relacionamento = new HashSet<Relacionamento>();
            ServicoPessoaEntidade = new HashSet<ServicoPessoaEntidade>();
            SolicitacaoEntidadeItem = new HashSet<SolicitacaoEntidadeItem>();
            TipoDocumentoPessoaEntidade = new HashSet<TipoDocumentoPessoaEntidade>();
            UnidadeOrganizacionalPessoaEntidade = new HashSet<UnidadeOrganizacionalPessoaEntidade>();
        }

        public int IdPessoaEntidade { get; set; }
        public string NmEntidade { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public short? NrNivel { get; set; }

        public virtual ICollection<Documento> Documento { get; set; }
        public virtual ICollection<ExamePessoaEntidade> ExamePessoaEntidade { get; set; }
        public virtual ICollection<LaboratorioPedido> LaboratorioPedido { get; set; }
        public virtual ICollection<PessoaCaracteristicaHistorico> PessoaCaracteristicaHistorico { get; set; }
        public virtual ICollection<PessoaEntidadePessoaAtributo> PessoaEntidadePessoaAtributo { get; set; }
        public virtual ICollection<PessoaEntidadePessoaEntidade> PessoaEntidadePessoaEntidadeIdPessoaEntidadeFilhoNavigation { get; set; }
        public virtual ICollection<PessoaEntidadePessoaEntidade> PessoaEntidadePessoaEntidadeIdPessoaEntidadePaiNavigation { get; set; }
        public virtual ICollection<RegistroEletronicoItemModeloAtributoPessoaEntidade> RegistroEletronicoItemModeloAtributoPessoaEntidade { get; set; }
        public virtual ICollection<RegistroEletronicoModeloPessoaEntidade> RegistroEletronicoModeloPessoaEntidade { get; set; }
        public virtual ICollection<RegistroEletronicoTipoPessoaEntidade> RegistroEletronicoTipoPessoaEntidade { get; set; }
        public virtual ICollection<Relacionamento> Relacionamento { get; set; }
        public virtual ICollection<ServicoPessoaEntidade> ServicoPessoaEntidade { get; set; }
        public virtual ICollection<SolicitacaoEntidadeItem> SolicitacaoEntidadeItem { get; set; }
        public virtual ICollection<TipoDocumentoPessoaEntidade> TipoDocumentoPessoaEntidade { get; set; }
        public virtual ICollection<UnidadeOrganizacionalPessoaEntidade> UnidadeOrganizacionalPessoaEntidade { get; set; }
    }
}