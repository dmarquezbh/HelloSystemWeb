﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LogCpc
    {
        public LogCpc()
        {
            LogFaixaCpc = new HashSet<LogFaixaCpc>();
        }

        public int CpcNu { get; set; }
        public int LocNu { get; set; }
        public string CpcNo { get; set; }
        public string CpcEndereco { get; set; }
        public string Cep { get; set; }
        public int CpcNuEct { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual LogLocalidade LocNuNavigation { get; set; }
        public virtual ICollection<LogFaixaCpc> LogFaixaCpc { get; set; }
    }
}