﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class IndicadorEconomico
    {
        public int IdIndicadorEconomico { get; set; }
        public int IdIndicadorEconomicoTipo { get; set; }
        public int NrMes { get; set; }
        public int NrAno { get; set; }
        public double PrIndicadorEconomico { get; set; }

        public virtual TipoDiversos IdIndicadorEconomicoTipoNavigation { get; set; }
    }
}