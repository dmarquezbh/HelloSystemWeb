﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RetornoUnimedTxt
    {
        public byte IdTipoReg { get; set; }
        public string IdTipoLinha { get; set; }
        public int IdArquivo { get; set; }
        public string NmArquivoUnimed { get; set; }
        public DateTime? DtLeitura { get; set; }
        public int NrOrdemLinha { get; set; }
        public string ContaCompetencia { get; set; }
        public string MesAnoMapa { get; set; }
        public string NmOperadora { get; set; }
        public int? IdLote { get; set; }
        public int? IdConta { get; set; }
        public DateTime? DtFechamento { get; set; }
        public string NmPlano { get; set; }
        public string NmPessoa { get; set; }
        public int? IdFechamentoItem { get; set; }
        public string InContaComErro { get; set; }
        public string CdItem { get; set; }
        public string TipoItem { get; set; }
        public string CdPrestadorExec { get; set; }
        public string CdPrestadorCobr { get; set; }
        public DateTime? DtRealizacaoItem { get; set; }
        public string TxDescricaoItem { get; set; }
        public string TxUnidade { get; set; }
        public int? IdTipoItem { get; set; }
        public decimal? QdCobradaItem { get; set; }
        public decimal? QdPagaItem { get; set; }
        public double? VlUnitario { get; set; }
        public decimal? VlCobradoItem { get; set; }
        public decimal? VlPagoItem { get; set; }
        public decimal? QdFilmePagoItem { get; set; }
        public decimal? VlFilmePagoItem { get; set; }
        public byte? PrPagamentoItem { get; set; }
        public string TxMesanoCompetenciaItem { get; set; }
        public string CdAdequacaoItem { get; set; }
        public string TxMsgAdequacaoItem { get; set; }
        public string InExisteComplementacaoPagto { get; set; }
        public decimal? QdUtItem { get; set; }
        public decimal? VlUtItem { get; set; }
        public string CdItemAdequacao { get; set; }
        public string InAdequacaoCodigo { get; set; }
        public decimal? VlSeriaPago { get; set; }
        public decimal? QdPagaAdequacao { get; set; }
        public decimal? VlPagoAdequacao { get; set; }
        public decimal? QdUtAdequacao { get; set; }
        public decimal? VlUtAdequacao { get; set; }
        public string TxMesanoCompetenciaAdequacao { get; set; }
        public decimal? VlPagoAnteriorAdequacao { get; set; }
        public string TxMesanoPgAnteriorAdequacao { get; set; }
        public byte? PrPagamentoAdequacao { get; set; }
        public string IdJustificativaErroConta { get; set; }
        public string TxErroConta { get; set; }
        public string InErroContaReapresentavel { get; set; }
        public decimal? VlDiariasErroConta { get; set; }
        public decimal? VlTaxasErroConta { get; set; }
        public decimal? VlMateriaisErroConta { get; set; }
        public decimal? VlMedicamentosErroConta { get; set; }
        public decimal? VlGabaritosErroConta { get; set; }
        public decimal? VlHonorariosErroConta { get; set; }
        public decimal? VlExamesErroConta { get; set; }
        public decimal? VlConsultasErroConta { get; set; }
        public string IdJustificativaErroItem { get; set; }
        public string TxMsgErroItem { get; set; }
        public string InErroItemReapresentavel { get; set; }
        public string CdItemCreditoestorno { get; set; }
        public string TxTipoCreditoestorno { get; set; }
        public decimal? VlCreditoestorno { get; set; }
        public string CdPrestadorExecCreditoestorno { get; set; }
        public string CdPrestadorCobrCreditoestorno { get; set; }
        public DateTime? DtRealizacaoCreditoestorno { get; set; }
        public string IdMotivoCreditoestorno { get; set; }
        public string TxMotivoCreditoestorno { get; set; }
        public string TxComplementoCreditoestorno { get; set; }
        public int NrOrdemLinhaPai { get; set; }
        public int IdOperadorarecebimento { get; set; }
        public string TxDescricaoPagamento { get; set; }
    }
}