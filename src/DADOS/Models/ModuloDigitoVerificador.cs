﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ModuloDigitoVerificador
    {
        public ModuloDigitoVerificador()
        {
            OperadoraModuloDigitoVerificador = new HashSet<OperadoraModuloDigitoVerificador>();
        }

        public int IdModuloDigitoVerificador { get; set; }
        public string NmModuloDigitoVerificador { get; set; }
        public string TxDescricaoModulo { get; set; }

        public virtual ICollection<OperadoraModuloDigitoVerificador> OperadoraModuloDigitoVerificador { get; set; }
    }
}