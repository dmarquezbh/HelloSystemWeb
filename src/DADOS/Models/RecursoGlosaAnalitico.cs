﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class RecursoGlosaAnalitico
    {
        public int? IdCartarecurso { get; set; }
        public int? InReenvio { get; set; }
        public DateTime? DtImpressao { get; set; }
        public int IdOperadora { get; set; }
        public string NmOperadora { get; set; }
        public int IdLoteContaMapa { get; set; }
        public string Mapa { get; set; }
        public int IdConta { get; set; }
        public int IdFechamentoItem { get; set; }
        public double VlRecursadoTotal { get; set; }
        public int? ItemAcatado { get; set; }
        public double VlAcatado { get; set; }
        public int? ItemRevertido { get; set; }
        public double VlRevertido { get; set; }
        public DateTime? DtRecurso { get; set; }
        public int? IdLote { get; set; }
    }
}