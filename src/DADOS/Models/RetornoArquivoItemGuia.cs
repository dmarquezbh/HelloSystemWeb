﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RetornoArquivoItemGuia
    {
        public int IdRetornoArquivoItemGuia { get; set; }
        public int IdRetornoArquivoGuia { get; set; }
        public DateTime? DtRealizacao { get; set; }
        public string Tabela { get; set; }
        public string CodigoProcedimentoItemAssistencial { get; set; }
        public string Descricao { get; set; }
        public string GrauParticipacao { get; set; }
        public decimal VlInformado { get; set; }
        public decimal QtExecutada { get; set; }
        public decimal VlProcessado { get; set; }
        public decimal VlLiberado { get; set; }
        public decimal VlGlosa { get; set; }
        public string CodigoGlosa { get; set; }
        public bool InProcessado { get; set; }
        public int? IdConta { get; set; }
        public int? IdFechamentoItem { get; set; }
        public bool InValorCreditoProcessado { get; set; }
        public bool InValorEstornoProcessado { get; set; }
        public bool InValorReversaoGlosaProcessado { get; set; }
        public bool InValorAcrescimoProcessado { get; set; }
        public bool InValorTotalGlosadoProcessado { get; set; }
        public bool InValorGlosadoProcessado { get; set; }

        public virtual RetornoArquivoGuia IdRetornoArquivoGuiaNavigation { get; set; }
    }
}