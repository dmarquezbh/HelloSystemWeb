﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class ControleVisitantesHistorico
    {
        public int IdControleVisitante { get; set; }
        public int IdLeito { get; set; }
        public int IdAtendimento { get; set; }
        public int IdUsuario { get; set; }
        public int NrCracha { get; set; }
        public string NmVisitante { get; set; }
        public string NrDocumento { get; set; }
        public DateTime DtEntradaVisitante { get; set; }
        public DateTime? DtSaidaVisitante { get; set; }
        public bool InAcompanhante { get; set; }
        public bool InAtivo { get; set; }
    }
}