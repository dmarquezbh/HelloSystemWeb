﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class FilaContaHistorico
    {
        public int IdHistoricoFilaConta { get; set; }
        public int IdFilaConta { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public string TxMsgErro { get; set; }

        public virtual FilaConta IdFilaContaNavigation { get; set; }
    }
}