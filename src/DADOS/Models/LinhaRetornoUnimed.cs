﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LinhaRetornoUnimed
    {
        public int IdArquivoUnimed { get; set; }
        public int NrOrdemLinha { get; set; }
        public byte NrTipoLinha { get; set; }

        public virtual ArquivoUnimed IdArquivoUnimedNavigation { get; set; }
        public virtual LinhaRetornoUnimedConta LinhaRetornoUnimedConta { get; set; }
        public virtual LinhaRetornoUnimedErro LinhaRetornoUnimedErro { get; set; }
        public virtual LinhaRetornoUnimedItem LinhaRetornoUnimedItem { get; set; }
        public virtual LinhaRetornoUnimedItemAdequacao LinhaRetornoUnimedItemAdequacao { get; set; }
        public virtual LinhaRetornoUnimedItemCreditoEstorno LinhaRetornoUnimedItemCreditoEstorno { get; set; }
        public virtual LinhaRetornoUnimedItemErro LinhaRetornoUnimedItemErro { get; set; }
    }
}