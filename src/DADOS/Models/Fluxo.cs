﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class Fluxo
    {
        public Fluxo()
        {
            ExamePrioridade = new HashSet<ExamePrioridade>();
            FluxoEtapa = new HashSet<FluxoEtapa>();
        }

        public int IdFluxo { get; set; }
        public string NmFluxo { get; set; }
        public int? QnPrazoEntrega { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual ICollection<ExamePrioridade> ExamePrioridade { get; set; }
        public virtual ICollection<FluxoEtapa> FluxoEtapa { get; set; }
    }
}