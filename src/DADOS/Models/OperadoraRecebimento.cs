﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OperadoraRecebimento
    {
        public OperadoraRecebimento()
        {
            ArquivoUnimed = new HashSet<ArquivoUnimed>();
            ContaCobrancaComplementoHistorico = new HashSet<ContaCobrancaComplementoHistorico>();
            OperadoraRecebimentoLancamentoBancario = new HashSet<OperadoraRecebimentoLancamentoBancario>();
            OperadoraRecebimentoParcelaSemConciliacao = new HashSet<OperadoraRecebimentoParcelaSemConciliacao>();
            OperadoraRecebimentoRetornoArquivo = new HashSet<OperadoraRecebimentoRetornoArquivo>();
        }

        public int IdOperadorarecebimento { get; set; }
        public int IdOperadora { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime? DtAtualizacao { get; set; }
        public bool? InAtivo { get; set; }
        public string TxDescricao { get; set; }
        public string TxPastaXml { get; set; }
        public string TxArquivoLog { get; set; }
        public int? IdUsuarioLiberouProcessamento { get; set; }
        public DateTime? DtImportacao { get; set; }
        public DateTime? DtProcessamento { get; set; }
        public bool InErroProcessamento { get; set; }
        public int IdTipoArquivo { get; set; }
        public string TxArquivoEnviado { get; set; }
        public int QdArqRet { get; set; }
        public int? IdLoteContaMapa { get; set; }
        public string TxMsgErro { get; set; }
        public DateTime? DtProcessamentoFinalizado { get; set; }
        public bool InSomenteCargaXml { get; set; }
        public bool InRepasseLiberado { get; set; }

        public virtual LoteContaMapa IdLoteContaMapaNavigation { get; set; }
        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual TipoDiversos IdTipoArquivoNavigation { get; set; }
        public virtual Usuario IdUsuarioLiberouProcessamentoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<ArquivoUnimed> ArquivoUnimed { get; set; }
        public virtual ICollection<ContaCobrancaComplementoHistorico> ContaCobrancaComplementoHistorico { get; set; }
        public virtual ICollection<OperadoraRecebimentoLancamentoBancario> OperadoraRecebimentoLancamentoBancario { get; set; }
        public virtual ICollection<OperadoraRecebimentoParcelaSemConciliacao> OperadoraRecebimentoParcelaSemConciliacao { get; set; }
        public virtual ICollection<OperadoraRecebimentoRetornoArquivo> OperadoraRecebimentoRetornoArquivo { get; set; }
    }
}