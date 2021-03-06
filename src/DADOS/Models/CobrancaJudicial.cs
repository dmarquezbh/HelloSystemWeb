﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class CobrancaJudicial
    {
        public CobrancaJudicial()
        {
            Audiencia = new HashSet<Audiencia>();
        }

        public int IdConta { get; set; }
        public int? IdExecutor { get; set; }
        public string TxObservacao { get; set; }
        public DateTime? DtBaixa { get; set; }
        public DateTime? DtRemessa { get; set; }
        public double? VlPago { get; set; }

        public virtual Pessoa IdExecutorNavigation { get; set; }
        public virtual ICollection<Audiencia> Audiencia { get; set; }
    }
}