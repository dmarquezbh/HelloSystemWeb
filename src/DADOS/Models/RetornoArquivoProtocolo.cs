﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RetornoArquivoProtocolo
    {
        public RetornoArquivoProtocolo()
        {
            RetornoArquivoGuia = new HashSet<RetornoArquivoGuia>();
        }

        public int IdRetornoArquivoProtocolo { get; set; }
        public int IdRetornoArquivoTotalGeral { get; set; }
        public int NrLote { get; set; }
        public string NrProtocolo { get; set; }
        public DateTime? DtProtocolo { get; set; }
        public string CodigoGlosaProtocolo { get; set; }
        public string CodigoSituacaoProtocolo { get; set; }
        public decimal VlInformadoProtocolo { get; set; }
        public decimal VlProcessadoProtocolo { get; set; }
        public decimal VlLiberadoProtocolo { get; set; }
        public decimal VlGlosaProtocolo { get; set; }

        public virtual RetornoArquivoTotalGeral IdRetornoArquivoTotalGeralNavigation { get; set; }
        public virtual ICollection<RetornoArquivoGuia> RetornoArquivoGuia { get; set; }
    }
}