﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PlanoContas
    {
        public PlanoContas()
        {
            ArquivoContabilItemIdPlanoContasContaContrapartidaNavigation = new HashSet<ArquivoContabilItem>();
            ArquivoContabilItemIdPlanoContasContaCreditoNavigation = new HashSet<ArquivoContabilItem>();
            ArquivoContabilItemIdPlanoContasContaDebitoNavigation = new HashSet<ArquivoContabilItem>();
            ClassificacaoProdutoPlanoContaContabil = new HashSet<ClassificacaoProdutoPlanoContaContabil>();
            ContaPagarRateio = new HashSet<ContaPagarRateio>();
            DefaultContabil = new HashSet<DefaultContabil>();
            InverseIdContaPaiNavigation = new HashSet<PlanoContas>();
            PessoaPlanoContas = new HashSet<PessoaPlanoContas>();
        }

        public int IdPlanoContas { get; set; }
        public int? IdContaPai { get; set; }
        public string CdConta { get; set; }
        public int CdReduzido { get; set; }
        public bool InSintetica { get; set; }
        public string NmConta { get; set; }
        public string TxDescricao { get; set; }
        public DateTime DtCadastro { get; set; }
        public int IdUsuario { get; set; }
        public bool? InContaAtiva { get; set; }
        public bool? InAtivo { get; set; }
        public int NrGrau { get; set; }
        public string TxNatureza { get; set; }

        public virtual PlanoContas IdContaPaiNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ArquivoContabilItem> ArquivoContabilItemIdPlanoContasContaContrapartidaNavigation { get; set; }
        public virtual ICollection<ArquivoContabilItem> ArquivoContabilItemIdPlanoContasContaCreditoNavigation { get; set; }
        public virtual ICollection<ArquivoContabilItem> ArquivoContabilItemIdPlanoContasContaDebitoNavigation { get; set; }
        public virtual ICollection<ClassificacaoProdutoPlanoContaContabil> ClassificacaoProdutoPlanoContaContabil { get; set; }
        public virtual ICollection<ContaPagarRateio> ContaPagarRateio { get; set; }
        public virtual ICollection<DefaultContabil> DefaultContabil { get; set; }
        public virtual ICollection<PlanoContas> InverseIdContaPaiNavigation { get; set; }
        public virtual ICollection<PessoaPlanoContas> PessoaPlanoContas { get; set; }
    }
}