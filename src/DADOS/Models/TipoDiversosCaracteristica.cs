﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TipoDiversosCaracteristica
    {
        public int IdTipoDiversos { get; set; }
        public int IdAtributo { get; set; }
        public string TxValorAtributo { get; set; }
        public bool? InAtivo { get; set; }

        public virtual Atributo IdAtributoNavigation { get; set; }
        public virtual TipoDiversos IdTipoDiversosNavigation { get; set; }
    }
}