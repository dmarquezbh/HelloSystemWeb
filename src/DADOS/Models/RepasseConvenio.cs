﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RepasseConvenio
    {
        public string NmMedico { get; set; }
        public int? IdMedico { get; set; }
        public string NmUnidadeRepasse { get; set; }
        public int IdUnidadeRepasse { get; set; }
        public string NmUnidadeAbertura { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string NmPaciente { get; set; }
        public int IdConta { get; set; }
        public int NrNotaFiscal { get; set; }
        public string TxDescricaoServico { get; set; }
        public double QnServico { get; set; }
        public double? VlServico { get; set; }
        public double? VlGlosado { get; set; }
        public string NmNotaEmitidaSituacao { get; set; }
        public string NmClassificacao { get; set; }
        public string ServicoDependente { get; set; }
    }
}