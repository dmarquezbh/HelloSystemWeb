﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TipoTabela
    {
        public TipoTabela()
        {
            AtendimentoDecisao = new HashSet<AtendimentoDecisao>();
            Atributo = new HashSet<Atributo>();
            AtributoTipoDiversosTipoTabela = new HashSet<AtributoTipoDiversosTipoTabela>();
            ExameItemColeta = new HashSet<ExameItemColeta>();
            ExameItemExameTipoTabela = new HashSet<ExameItemExameTipoTabela>();
            ExameItemMaterial = new HashSet<ExameItemMaterial>();
            MensagemTipo = new HashSet<MensagemTipo>();
            ParametrizacaoSistema = new HashSet<ParametrizacaoSistema>();
            TabelaClassificacao = new HashSet<TabelaClassificacao>();
            TipoDiversos = new HashSet<TipoDiversos>();
            TipoTabelaTipoTabelaIdTipoTabelaFilhoNavigation = new HashSet<TipoTabelaTipoTabela>();
            TipoTabelaTipoTabelaIdTipoTabelaPaiNavigation = new HashSet<TipoTabelaTipoTabela>();
            Tisstipo = new HashSet<Tisstipo>();
        }

        public int IdTipoTabela { get; set; }
        public string NmTipoTabela { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual ICollection<AtendimentoDecisao> AtendimentoDecisao { get; set; }
        public virtual ICollection<Atributo> Atributo { get; set; }
        public virtual ICollection<AtributoTipoDiversosTipoTabela> AtributoTipoDiversosTipoTabela { get; set; }
        public virtual ICollection<ExameItemColeta> ExameItemColeta { get; set; }
        public virtual ICollection<ExameItemExameTipoTabela> ExameItemExameTipoTabela { get; set; }
        public virtual ICollection<ExameItemMaterial> ExameItemMaterial { get; set; }
        public virtual ICollection<MensagemTipo> MensagemTipo { get; set; }
        public virtual ICollection<ParametrizacaoSistema> ParametrizacaoSistema { get; set; }
        public virtual ICollection<TabelaClassificacao> TabelaClassificacao { get; set; }
        public virtual ICollection<TipoDiversos> TipoDiversos { get; set; }
        public virtual ICollection<TipoTabelaTipoTabela> TipoTabelaTipoTabelaIdTipoTabelaFilhoNavigation { get; set; }
        public virtual ICollection<TipoTabelaTipoTabela> TipoTabelaTipoTabelaIdTipoTabelaPaiNavigation { get; set; }
        public virtual ICollection<Tisstipo> Tisstipo { get; set; }
    }
}