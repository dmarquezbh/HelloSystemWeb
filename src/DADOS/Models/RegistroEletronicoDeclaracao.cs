﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RegistroEletronicoDeclaracao
    {
        public int IdRegistroEletronicoDeclaracao { get; set; }
        public int IdAtendimento { get; set; }
        public string TxDeclaracao { get; set; }
        public bool? InAtivo { get; set; }
        public DateTime DtRegistro { get; set; }
        public int IdStatus { get; set; }

        public virtual Atendimento IdAtendimentoNavigation { get; set; }
        public virtual TipoDiversos IdStatusNavigation { get; set; }
    }
}