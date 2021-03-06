﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ContaTotais
    {
        public int IdOperadora { get; set; }
        public string NmOperadora { get; set; }
        public int? IdLote { get; set; }
        public string DtGeracaoLote { get; set; }
        public int IdLoteContaMapa { get; set; }
        public string Mapa { get; set; }
        public string MesMapa { get; set; }
        public string AnoMapa { get; set; }
        public string TipoInternoExterno { get; set; }
        public int IdConta { get; set; }
        public string NmPaciente { get; set; }
        public bool? InRejeitada { get; set; }
        public double VlFaturado { get; set; }
        public double VlGlosado { get; set; }
        public double VlFi { get; set; }
        public double VlGlosaGenerica { get; set; }
        public decimal VlCredito { get; set; }
        public decimal VlEstorno { get; set; }
        public double VlAcrescimoGenerico { get; set; }
        public double VlAcrescimos { get; set; }
        public decimal VlRecebido { get; set; }
        public double VlRecursado { get; set; }
        public decimal? VlAcatado { get; set; }
        public decimal VlAcatadoItens { get; set; }
        public decimal VlAcatadoGen { get; set; }
        public double VlRevertido { get; set; }
        public double VlRevertidoSemRecurso { get; set; }
        public decimal? VlAcatadoComRecurso { get; set; }
        public decimal? VlAcatadoSemRecurso { get; set; }
        public string NmMesMapa { get; set; }
        public decimal? ValorAApurarRecebimento { get; set; }
        public decimal? ValorAApurarGlosa { get; set; }
        public decimal? ValorAApurarRecurso { get; set; }
        public decimal? ValorAApurar { get; set; }
        public DateTime? DtLiberacaoLoteCobranca { get; set; }
    }
}