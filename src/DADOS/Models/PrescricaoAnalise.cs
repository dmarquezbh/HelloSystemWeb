﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PrescricaoAnalise
    {
        public int IdPrescricao { get; set; }
        public string TxObservacao { get; set; }
        public int IdUsuarioAnalise { get; set; }
        public bool InAtivo { get; set; }
        public DateTime? DtPrescricaoAnalise { get; set; }
        public int? NecessidadeFarmacoterapeutica { get; set; }
        public int? Prm { get; set; }
        public bool? InAnaliseParcial { get; set; }

        public virtual Usuario IdUsuarioAnaliseNavigation { get; set; }
    }
}