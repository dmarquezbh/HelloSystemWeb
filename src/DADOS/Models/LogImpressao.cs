﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class LogImpressao
    {
        public int IdLogImpressao { get; set; }
        public string TxXml { get; set; }
        public string TxComando { get; set; }
        public DateTime DtImpressao { get; set; }
        public int IdUsuarioImpressao { get; set; }
        public int? IdTipoEtiqueta { get; set; }
        public int? IdAtendimento { get; set; }

        public virtual TipoDiversos IdTipoEtiquetaNavigation { get; set; }
        public virtual Usuario IdUsuarioImpressaoNavigation { get; set; }
    }
}