﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LinhaRetornoUnimedItem
    {
        public LinhaRetornoUnimedItem()
        {
            LinhaRetornoUnimedItemAdequacao = new HashSet<LinhaRetornoUnimedItemAdequacao>();
            LinhaRetornoUnimedItemCreditoEstorno = new HashSet<LinhaRetornoUnimedItemCreditoEstorno>();
            LinhaRetornoUnimedItemErro = new HashSet<LinhaRetornoUnimedItemErro>();
        }

        public int IdArquivoUnimed { get; set; }
        public int NrOrdemLinha { get; set; }
        public int? IdConta { get; set; }
        public int? IdFechamentoItem { get; set; }
        public string CdPrestadorExec { get; set; }
        public string CdPrestadorCobr { get; set; }
        public DateTime? DtRealizacao { get; set; }
        public int? IdTipoItem { get; set; }
        public string CdItem { get; set; }
        public decimal? QdCobrada { get; set; }
        public decimal? QdPaga { get; set; }
        public decimal? VlCobrado { get; set; }
        public decimal? VlPago { get; set; }
        public decimal? QdFilme { get; set; }
        public decimal? VlFilmePago { get; set; }
        public decimal? VlUt { get; set; }
        public byte? PrPagamento { get; set; }
        public string TxMesanoCompetencia { get; set; }
        public string CdAdequacao { get; set; }
        public string TxMsgAdequacao { get; set; }
        public bool InComplPagto { get; set; }
        public decimal? QdUt { get; set; }
        public string TxUsoLivre { get; set; }

        public virtual LinhaRetornoUnimed LinhaRetornoUnimed { get; set; }
        public virtual ICollection<LinhaRetornoUnimedItemAdequacao> LinhaRetornoUnimedItemAdequacao { get; set; }
        public virtual ICollection<LinhaRetornoUnimedItemCreditoEstorno> LinhaRetornoUnimedItemCreditoEstorno { get; set; }
        public virtual ICollection<LinhaRetornoUnimedItemErro> LinhaRetornoUnimedItemErro { get; set; }
    }
}