﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Imposto
    {
        public Imposto()
        {
            TipoContaReceberImposto = new HashSet<TipoContaReceberImposto>();
        }

        public int IdImposto { get; set; }
        public int? CdImposto { get; set; }
        public string NmImposto { get; set; }
        public int IdTipoImposto { get; set; }
        public double VlAliquota { get; set; }
        public float? VlPis { get; set; }
        public float? VlCofins { get; set; }
        public float? VlCsll { get; set; }
        public int IdRecolhimentoTipo { get; set; }

        public virtual ICollection<TipoContaReceberImposto> TipoContaReceberImposto { get; set; }
    }
}