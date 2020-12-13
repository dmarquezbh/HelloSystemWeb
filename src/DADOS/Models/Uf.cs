﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Uf
    {
        public Uf()
        {
            Feriado = new HashSet<Feriado>();
            LogFaixaUf = new HashSet<LogFaixaUf>();
            LogLocalidade = new HashSet<LogLocalidade>();
        }

        public string SgUf { get; set; }
        public string NmUf { get; set; }
        public int IdPais { get; set; }
        public int IdUf { get; set; }
        public byte[] RvVersaoLinha { get; set; }
        public bool? InAtivo { get; set; }
        public string CdIbge { get; set; }

        public virtual Pais IdPaisNavigation { get; set; }
        public virtual ICollection<Feriado> Feriado { get; set; }
        public virtual ICollection<LogFaixaUf> LogFaixaUf { get; set; }
        public virtual ICollection<LogLocalidade> LogLocalidade { get; set; }
    }
}