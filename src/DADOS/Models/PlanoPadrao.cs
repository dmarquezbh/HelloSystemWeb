﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DADOS.Models
{
    public partial class PlanoPadrao
    {
        public int IdPlano { get; set; }
        public int IdAcomodacao { get; set; }
        public bool? InAtivo { get; set; }
        public byte[] RvVersaoLinha { get; set; }

        public virtual TipoDiversos IdAcomodacaoNavigation { get; set; }
        public virtual Plano IdPlanoNavigation { get; set; }
    }
}