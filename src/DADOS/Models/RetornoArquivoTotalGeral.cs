﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RetornoArquivoTotalGeral
    {
        public RetornoArquivoTotalGeral()
        {
            RetornoArquivoProtocolo = new HashSet<RetornoArquivoProtocolo>();
        }

        public int IdRetornoArquivoTotalGeral { get; set; }
        public int IdRetornoArquivoProcessamento { get; set; }
        public decimal VlInformadoGeral { get; set; }
        public decimal VlProcessadoGeral { get; set; }
        public decimal VlLiberadoGeral { get; set; }
        public decimal VlGlosaGeral { get; set; }

        public virtual RetornoArquivoProcessamento IdRetornoArquivoProcessamentoNavigation { get; set; }
        public virtual ICollection<RetornoArquivoProtocolo> RetornoArquivoProtocolo { get; set; }
    }
}