﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LinhaRetornoUnimedItemErro
    {
        public int IdArquivoUnimed { get; set; }
        public int NrOrdemLinha { get; set; }
        public int NrOrdemLinhaPai { get; set; }
        public int? IdConta { get; set; }
        public int? IdFechamentoItem { get; set; }
        public string IdJustificativa { get; set; }
        public string TxMsgErro { get; set; }
        public bool? InReapresentavel { get; set; }

        public virtual LinhaRetornoUnimed LinhaRetornoUnimed { get; set; }
        public virtual LinhaRetornoUnimedItem LinhaRetornoUnimedItem { get; set; }
    }
}