﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LogFaixaCpc
    {
        public int CpcNu { get; set; }
        public string CpcInicial { get; set; }
        public string CpcFinal { get; set; }
        public int CpcNuEct { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual LogCpc CpcNuNavigation { get; set; }
    }
}