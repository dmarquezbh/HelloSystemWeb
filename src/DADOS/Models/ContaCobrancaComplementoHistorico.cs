﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ContaCobrancaComplementoHistorico
    {
        public int IdContaCobrancaComplementoHistorico { get; set; }
        public int IdConta { get; set; }
        public DateTime? DtBaixaConvenio { get; set; }
        public DateTime? DtBaixaParticular { get; set; }
        public decimal? VlTotalPago { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdSituacao { get; set; }
        public int? NrLancamentoBancario { get; set; }
        public bool InConciliada { get; set; }
        public bool InEnviada { get; set; }
        public decimal? VlFaturado { get; set; }
        public bool InExcluido { get; set; }
        public DateTime? DtConfirmacaoConciliacao { get; set; }
        public int? IdMovimentacaocontaparcelabaixada { get; set; }
        public int? IdCartarecurso { get; set; }
        public int? IdOperadorarecebimento { get; set; }
        public int? IdFaturamentobaixagrupo { get; set; }
        public int? IdLancamentoBancario { get; set; }
        public decimal VlAcrescimos { get; set; }
        public int? IdArquivoEletronico { get; set; }
        public decimal VlDesconto { get; set; }
        public decimal VlLiqRecebSemAcresc { get; set; }
        public decimal VlReversao { get; set; }

        public virtual CartaRecurso IdCartarecursoNavigation { get; set; }
        public virtual ContaCobranca IdContaNavigation { get; set; }
        public virtual FaturamentoBaixaGrupo IdFaturamentobaixagrupoNavigation { get; set; }
        public virtual LancamentoBancario IdLancamentoBancarioNavigation { get; set; }
        public virtual OperadoraRecebimento IdOperadorarecebimentoNavigation { get; set; }
        public virtual TipoDiversos IdSituacaoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}