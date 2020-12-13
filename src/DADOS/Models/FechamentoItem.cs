﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class FechamentoItem
    {
        public FechamentoItem()
        {
            AcrescimosFechamentoItemValorLiberado = new HashSet<AcrescimosFechamentoItemValorLiberado>();
            AdequacaoCodigo = new HashSet<AdequacaoCodigo>();
            ContaItemFechamentoItem = new HashSet<ContaItemFechamentoItem>();
            FechamentoItemValorLiberado = new HashSet<FechamentoItemValorLiberado>();
            GlosaFechamentoItemValorLiberado = new HashSet<GlosaFechamentoItemValorLiberado>();
            RetornoFnIdentificaFchItemUnimed = new HashSet<RetornoFnIdentificaFchItemUnimed>();
        }

        public int IdConta { get; set; }
        public int IdFechamentoItem { get; set; }
        public int? IdTipoItem { get; set; }
        public DateTime DtLancamento { get; set; }
        public int NrAlicotaIss { get; set; }
        public string TxDescricao { get; set; }
        public double QdItem { get; set; }
        public string NmConsumoMinimo { get; set; }
        public double VlUnitario { get; set; }
        public double VlFechamentoItem { get; set; }
        public string NmClassificacao { get; set; }
        public string NmUnidadeOrganizacional { get; set; }
        public double? VlHonorario { get; set; }
        public double? VlCustoOperacional { get; set; }
        public double? VlFilme { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int? IdFechamentoItemPai { get; set; }
        public int? IdMedico { get; set; }
        public decimal? NrReducaoAcrescimo { get; set; }
        public int? IdServicoProdutoTabela { get; set; }
        public int? IdFuncao { get; set; }
        public bool? InAgrupado { get; set; }
        public bool? InProcedimentoPrincipalSus { get; set; }
        public int? IdServicoCategoria { get; set; }
        public int? IdClassificacaoPai { get; set; }
        public int? IdUnidadeFaturamento { get; set; }
        public double QdGlosaContaLimpa { get; set; }
        public double? VlGlosaContaLimpa { get; set; }
        public double? QdFiContaLimpa { get; set; }
        public double? VlFiContaLimpa { get; set; }
        public double? VlTerceiro { get; set; }

        public virtual TipoDiversos IdTipoItemNavigation { get; set; }
        public virtual Acrescimos Acrescimos { get; set; }
        public virtual FaturamentoIndevido FaturamentoIndevido { get; set; }
        public virtual FechamentoItemHonorarioCooperado FechamentoItemHonorarioCooperado { get; set; }
        public virtual Glosa Glosa { get; set; }
        public virtual ICollection<AcrescimosFechamentoItemValorLiberado> AcrescimosFechamentoItemValorLiberado { get; set; }
        public virtual ICollection<AdequacaoCodigo> AdequacaoCodigo { get; set; }
        public virtual ICollection<ContaItemFechamentoItem> ContaItemFechamentoItem { get; set; }
        public virtual ICollection<FechamentoItemValorLiberado> FechamentoItemValorLiberado { get; set; }
        public virtual ICollection<GlosaFechamentoItemValorLiberado> GlosaFechamentoItemValorLiberado { get; set; }
        public virtual ICollection<RetornoFnIdentificaFchItemUnimed> RetornoFnIdentificaFchItemUnimed { get; set; }
    }
}