﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TissfinalidadeOperadora
    {
        public int IdFinalidadeOperadora { get; set; }
        public int IdFinalidade { get; set; }
        public int IdOperadora { get; set; }
        public DateTime DtCadastro { get; set; }

        public virtual Tissfinalidade IdFinalidadeNavigation { get; set; }
        public virtual Pessoa IdOperadoraNavigation { get; set; }
    }
}