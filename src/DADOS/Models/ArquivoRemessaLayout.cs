﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ArquivoRemessaLayout
    {
        public ArquivoRemessaLayout()
        {
            ArquivoRemessaLayoutOperadora = new HashSet<ArquivoRemessaLayoutOperadora>();
            Tissversao = new HashSet<Tissversao>();
        }

        public int IdArquivoRemessaLayout { get; set; }
        public string NmArquivoRemessaLayout { get; set; }
        public bool? InAtivo { get; set; }

        public virtual ICollection<ArquivoRemessaLayoutOperadora> ArquivoRemessaLayoutOperadora { get; set; }
        public virtual ICollection<Tissversao> Tissversao { get; set; }
    }
}