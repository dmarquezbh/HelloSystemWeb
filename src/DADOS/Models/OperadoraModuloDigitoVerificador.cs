﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class OperadoraModuloDigitoVerificador
    {
        public int IdModuloDigitoVerificador { get; set; }
        public int IdOperadora { get; set; }
        public bool InMatricula { get; set; }
        public bool? InCartao { get; set; }

        public virtual ModuloDigitoVerificador IdModuloDigitoVerificadorNavigation { get; set; }
        public virtual Pessoa IdOperadoraNavigation { get; set; }
    }
}