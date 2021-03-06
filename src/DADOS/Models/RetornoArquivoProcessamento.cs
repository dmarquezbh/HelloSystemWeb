﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RetornoArquivoProcessamento
    {
        public RetornoArquivoProcessamento()
        {
            FechamentoItemValorLiberado = new HashSet<FechamentoItemValorLiberado>();
            RetornoArquivoTotalGeral = new HashSet<RetornoArquivoTotalGeral>();
        }

        public int IdRetornoArquivoProcessamento { get; set; }
        public int IdRetornoArquivo { get; set; }
        public int IdUsuarioImportacao { get; set; }
        public DateTime DtImportacao { get; set; }
        public int? IdUsuarioProcessamento { get; set; }
        public DateTime? DtProcessamento { get; set; }
        public DateTime? DtIniProcessamento { get; set; }
        public bool InErroProcessamento { get; set; }

        public virtual RetornoArquivo IdRetornoArquivoNavigation { get; set; }
        public virtual Usuario IdUsuarioImportacaoNavigation { get; set; }
        public virtual Usuario IdUsuarioProcessamentoNavigation { get; set; }
        public virtual ICollection<FechamentoItemValorLiberado> FechamentoItemValorLiberado { get; set; }
        public virtual ICollection<RetornoArquivoTotalGeral> RetornoArquivoTotalGeral { get; set; }
    }
}