﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Carencia
    {
        public Carencia()
        {
            CarenciaHistorico = new HashSet<CarenciaHistorico>();
        }

        public int IdCarencia { get; set; }
        public int IdOperadora { get; set; }
        public int? IdPlano { get; set; }
        public int IdCarenciaTipo { get; set; }
        public int NrPeriodo { get; set; }
        public int IdUnidadeTempo { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual TipoDiversos IdCarenciaTipoNavigation { get; set; }
        public virtual Pessoa IdOperadoraNavigation { get; set; }
        public virtual Plano IdPlanoNavigation { get; set; }
        public virtual TipoDiversos IdUnidadeTempoNavigation { get; set; }
        public virtual ICollection<CarenciaHistorico> CarenciaHistorico { get; set; }
    }
}