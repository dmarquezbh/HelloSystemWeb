﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class TissfinalidadeCampoValor
    {
        public int IdFinalidadeCampoValor { get; set; }
        public int IdFinalidade { get; set; }
        public string NmCampo { get; set; }
        public string TxXpathCampo { get; set; }
        public string TxValorCampo { get; set; }
        public int? IdFonteDados { get; set; }
        public string TxNomeCampo { get; set; }
        public int? IdOperadora { get; set; }
        public DateTime? DtGravacao { get; set; }

        public virtual Tissfinalidade IdFinalidadeNavigation { get; set; }
        public virtual TissfonteDados IdFonteDadosNavigation { get; set; }
    }
}