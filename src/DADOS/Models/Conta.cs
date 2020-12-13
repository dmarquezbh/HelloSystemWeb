﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Conta
    {
        public Conta()
        {
            ContaItem = new HashSet<ContaItem>();
            ContaItemComposicao = new HashSet<ContaItemComposicao>();
            ContaReceber = new HashSet<ContaReceber>();
            DocumentoHistorico = new HashSet<DocumentoHistorico>();
            FaturamentoBaixaGrupo = new HashSet<FaturamentoBaixaGrupo>();
            GlosaGenericaAcatada = new HashSet<GlosaGenericaAcatada>();
            InverseIdContaOrigemNavigation = new HashSet<Conta>();
            LinhaRetornoUnimedConta = new HashSet<LinhaRetornoUnimedConta>();
            NotaEmitidaConta = new HashSet<NotaEmitidaConta>();
            ServicoOrdem = new HashSet<ServicoOrdem>();
            SusArquivoGerado = new HashSet<SusArquivoGerado>();
            TissOutrasDespesas = new HashSet<TissOutrasDespesas>();
            TissProcedimentosExecutados = new HashSet<TissProcedimentosExecutados>();
            TissProcedimentosExecutadosUnimedBh = new HashSet<TissProcedimentosExecutadosUnimedBh>();
        }

        public int IdConta { get; set; }
        public int IdAtendimento { get; set; }
        public DateTime? DtFechamento { get; set; }
        public bool InParcial { get; set; }
        public bool InParticular { get; set; }
        public bool InCancelada { get; set; }
        public int? IdLote { get; set; }
        public bool InExterno { get; set; }
        public int? NrPermanecia { get; set; }
        public int? IdUsuarioCancelamento { get; set; }
        public string TxObservacao { get; set; }
        public bool InAuditada { get; set; }
        public bool InAuditoriaExterna { get; set; }
        public DateTime? DtEmissao { get; set; }
        public bool? InProcessando { get; set; }
        public bool InAvulsa { get; set; }
        public string CdConvenio { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public int? IdGuia { get; set; }
        public bool? InRejeitada { get; set; }
        public int? IdContaOrigem { get; set; }
        public decimal? VlHospital { get; set; }
        public decimal? VlTerceiro { get; set; }
        public decimal? VlTotal { get; set; }
        public int? QnTotalItem { get; set; }
        public DateTime? DtPreview { get; set; }

        public virtual Atendimento IdAtendimentoNavigation { get; set; }
        public virtual Conta IdContaOrigemNavigation { get; set; }
        public virtual LoteConta IdLoteNavigation { get; set; }
        public virtual Usuario IdUsuarioCancelamentoNavigation { get; set; }
        public virtual ContaComplemento ContaComplemento { get; set; }
        public virtual ContaDtLiberacaoTab ContaDtLiberacaoTab { get; set; }
        public virtual ICollection<ContaItem> ContaItem { get; set; }
        public virtual ICollection<ContaItemComposicao> ContaItemComposicao { get; set; }
        public virtual ICollection<ContaReceber> ContaReceber { get; set; }
        public virtual ICollection<DocumentoHistorico> DocumentoHistorico { get; set; }
        public virtual ICollection<FaturamentoBaixaGrupo> FaturamentoBaixaGrupo { get; set; }
        public virtual ICollection<GlosaGenericaAcatada> GlosaGenericaAcatada { get; set; }
        public virtual ICollection<Conta> InverseIdContaOrigemNavigation { get; set; }
        public virtual ICollection<LinhaRetornoUnimedConta> LinhaRetornoUnimedConta { get; set; }
        public virtual ICollection<NotaEmitidaConta> NotaEmitidaConta { get; set; }
        public virtual ICollection<ServicoOrdem> ServicoOrdem { get; set; }
        public virtual ICollection<SusArquivoGerado> SusArquivoGerado { get; set; }
        public virtual ICollection<TissOutrasDespesas> TissOutrasDespesas { get; set; }
        public virtual ICollection<TissProcedimentosExecutados> TissProcedimentosExecutados { get; set; }
        public virtual ICollection<TissProcedimentosExecutadosUnimedBh> TissProcedimentosExecutadosUnimedBh { get; set; }
    }
}