﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ExameExameAmostra
    {
        public int IdExamePai { get; set; }
        public int IdExameFilho { get; set; }
        public bool? InAtivo { get; set; }
        public DateTime DtCadastro { get; set; }

        public virtual Exame IdExameFilhoNavigation { get; set; }
        public virtual Exame IdExamePaiNavigation { get; set; }
    }
}