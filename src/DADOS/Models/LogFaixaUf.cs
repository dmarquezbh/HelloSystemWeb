﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LogFaixaUf
    {
        public int IdUf { get; set; }
        public string UfeCepIni { get; set; }
        public string UfeCepFim { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual Uf IdUfNavigation { get; set; }
    }
}